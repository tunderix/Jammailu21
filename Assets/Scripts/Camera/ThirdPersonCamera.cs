using UnityEngine;

namespace TerraFirma.Camera
{
    public class ThirdPersonCamera : MonoBehaviour

    {
        [SerializeField] Transform cam;
        [SerializeField] float speed = 6f;
        public CharacterController controller;
        public float turnSmoothTime = 0.1f;
        private float turnSmoothVelocity;

        // Update is called once per frame
        void Update()
        {
            //Moving with WASD and arrow keys without any smoothing. eg. -1 for "A", +1 for "D" 
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");


            //normilized so that if we press two keys at the same time we dont move faster.
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            //magnitude is length of our direction vector
            if (direction.magnitude >= 0.1f)
            {
                // Atan2 to see how much we need to rotate player on y axis to point in that direction
                // Atan2 0 = atan2(x/y)
                // Atan2 is math function that returns the angle between x axis and the vector starting at 0 terminating at x,y
                // Rad2Deg returns the radious of atan2 to degrees
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                //Quaternion.Euler takes 3 input numbers to determine rotation on x, y, z
                transform.rotation = Quaternion.Euler(0f, angle, 0f);
                //use * Vector3.forward to return direction instead of rotation
                Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                controller.Move(moveDirection.normalized * speed * Time.deltaTime);
            }
        }
    }
}
