using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TerraFirma
{
    public class script_PlayerController : MonoBehaviour
    {
        private MyControls playerInput;
        private Rigidbody rb;
        
        [SerializeField] private script_PlayerController controller;
        [SerializeField] private Animator animator;

        [SerializeField] private float aimingMoveSpeed = 3f;
        [SerializeField] private float aimingRotationSpeed = 2f;
        [SerializeField] private float runningSpeed = 10f;
        [SerializeField] private float runningRotationSpeed = 0.3f;
        [SerializeField] private float animationSpeed = 1f;
        [SerializeField] private float travelSpeed = 1f;
        [SerializeField] private float walkSpeed = 5f;
        [SerializeField] private float walkRotationSpeed = 5f;
        [SerializeField] private float sprintSpeed = 15f;
        [SerializeField] private float sprintRotationSpeed = 1f;
        [SerializeField] private Vector2 previousMoveInput;
        [SerializeField] private float previousAimInput;
        [SerializeField] private Vector2 aimInputTest;
        [SerializeField] private AnimationCurve curveTest;
   

        [SerializeField] private float aimingModeLayerWeight = 0f;

        private Vector2 aim;
        private Vector2 move;
        private bool isReloading = false;
        private float reloadTime;

        private bool aimMode;

        private InputAction action;
        public bool isMovingOnLand{
            get{
                return move!=Vector2.zero;
                //float activedistance = Vector2.Distance(Vector2.zero,playerInput.Land.Move.ReadValue<Vector2>());
                //if(deadzoneMin >= activedistance)return false;
                //else return true;
                //previousMoveInput>=playerInput.Land.Move.performed;
            }
            private set{isMovingOnLand = value;}
        }
        public bool isInAimMode{
            get{
                return aimMode;
            }
            private set{isInAimMode = value;}
        }
 
        void Awake()
        {
            playerInput = new MyControls();

            playerInput.Land.Move.performed += ctx => move = ForwardDirection.DirectionVector2(ctx.ReadValue<Vector2>());
            playerInput.Land.Move.canceled += ctx => move = Vector2.zero;

            
            //playerInput.Land.AimMode.started += ctx => aimMode = ctx.ReadValue<bool>();
            playerInput.Land.AimMode.performed += ctx => aimMode = ctx.ReadValue<float>() == 1;
            //playerInput.Land.AimMode.canceled += ctx => aimMode = false;


            playerInput.AimMode.Aim.performed += ctx => aim = ForwardDirection.DirectionVector2(ctx.ReadValue<Vector2>());
            playerInput.Land.Move.canceled += ctx => aim = Vector2.zero;

            

            rb = GetComponent<Rigidbody>();
        }
        private void Start() {
            OnEnable();
            
        }
        void Update()
        {
            float aimModeInput = playerInput.Land.AimMode.ReadValue<float>();
            bool sprintInput = playerInput.Land.Sprint.ReadValue<float>() == 1;
            float pullBowStringInput = playerInput.AimMode.DrawBow.ReadValue<float>();
            previousAimInput = aimModeInput;

            if(!isMovingOnLand){
                rb.velocity = Vector2.zero;
            }

            if(isMovingOnLand && !aimMode){          
                if(!sprintInput){
                    UpdateRotation(move, runningRotationSpeed);
                }            
                if(sprintInput){
                    UpdateRotation(move, sprintRotationSpeed);                    
                } 
            }
            
            if(aimMode){                
                if(aim != Vector2.zero)
                UpdateRotation(aim, aimingRotationSpeed);                
            }
            animationSpeed = ExtensionMethods.Remap(rb.velocity.magnitude,0,10,0,1);
            
            UpdateRunningAnimation(move, sprintInput);
            UpdateAimingAnimation(aim, pullBowStringInput);
            RunningAnimationBlend();
            aimInputTest = aim;
            aimingModeLayerWeight = animator.GetLayerWeight(2);
            if(playerInput.Land.Reload.triggered && !isReloading){
                StartCoroutine(Reload());
            }

            
        }
        private void OnEnable() {
            playerInput.Enable();
        }
        private void OnDisable() {
            playerInput.Disable();
        }
        private void FixedUpdate() {
            float aimModeInput = playerInput.Land.AimMode.ReadValue<float>();
            bool sprintInput = playerInput.Land.Sprint.ReadValue<float>() == 1;
            float pullBowStringInput = playerInput.AimMode.DrawBow.ReadValue<float>();
            previousAimInput = aimModeInput;

            if(!isMovingOnLand){
                rb.velocity = Vector2.zero;
            }

            if(isMovingOnLand && !aimMode){          
                if(!sprintInput){
                    UpdateVelocity(runningSpeed);
                }            
                if(sprintInput){
                    UpdateVelocity(sprintSpeed);
                } 
            }
            
            if(aimMode){                
                UpdateVelocity(aimingMoveSpeed);              
            }
        }
        private void UpdateRunningAnimation(Vector2 moveInput, bool sprintInput){
     
            
            animator.SetBool("isSprinting", isMovingOnLand && sprintInput && !isInAimMode);
            animator.SetBool("isRunning", isMovingOnLand && !sprintInput && !isInAimMode);
        }

        private void UpdateAimingAnimation(Vector2 aimInput,float pullBowStringInput){
            animator.SetBool("isAiming", aimMode);
            if(aimMode){                
                animator.SetLayerWeight(2,1);
                animator.SetFloat("PullBowStringBlend",pullBowStringInput);
            } 
            else {
                animator.SetLayerWeight(2,0);
            }                 
        }
        private void RunningAnimationBlend(){            
            animator.SetFloat("Blend",animationSpeed);            
        }
        private void UpdateVelocity(float moveSpeed){
            rb.velocity = ForwardDirection.DirectionVector3(move)*moveSpeed;
        }

        private void UpdateRotation(Vector2 aimInput, float rotationSpeed){
            float angleVector2 = Vector2.SignedAngle(new Vector2(1,0), aimInput);
            Debug.Log(angleVector2);
            animator.transform.SetPositionAndRotation(this.transform.localPosition,Quaternion.Slerp(animator.transform.rotation, Quaternion.Euler(0,angleVector2,0), rotationSpeed*Time.deltaTime));
            //animator.transform.SetPositionAndRotation(this.transform.localPosition,Quaternion.Slerp(animator.transform.rotation, Quaternion.Euler(LookDirection.DirectionVector(aimInput)),0.3f));
        }
        private IEnumerator Reload(){
                isReloading = true;
                animator.SetLayerWeight(1,1);
                animator.SetBool("isReloading", isReloading);
                reloadTime = 1.3f;
                Debug.Log("gtr");
                Debug.Log(reloadTime);
                yield return new WaitForSeconds (reloadTime);

                Invoke("ReloadComplete", reloadTime);
        }
        void ReloadComplete(){
            isReloading = false;
            animator.SetBool("isReloading", isReloading);
            animator.SetLayerWeight(1,0);            
        }

    }
            
}
