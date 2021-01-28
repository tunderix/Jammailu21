using UnityEngine;
using UnityEngine.AI;

namespace TerraFirma.Movement
{
    [RequireComponent(typeof(Rigidbody))]
    public class FixedMovement : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private Animator playerAnimator;


        Rigidbody _rigidbody { get => this.gameObject.GetComponent<Rigidbody>(); }

        private void FixedUpdate()
        {
            Vector3 moveForce = Vector3.zero;

            if (Input.GetKey(KeyCode.A))
                moveForce += MoveDirection.Left;
            if (Input.GetKey(KeyCode.D))
                moveForce += MoveDirection.Right;
            if (Input.GetKey(KeyCode.W))
                moveForce += MoveDirection.Up;
            if (Input.GetKey(KeyCode.S))
                moveForce += MoveDirection.Down;

            playerAnimator.SetBool("isRunning", moveForce != Vector3.zero);

            NavMeshAgent a = this.gameObject.GetComponent<NavMeshAgent>();
            a.Move(moveForce * speed * Time.deltaTime);
            //transform.Translate(moveForce * speed * Time.deltaTime);
        }
    }
}
