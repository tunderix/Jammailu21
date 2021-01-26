using UnityEngine;


namespace TerraFirma.Camera
{
    public class CameraFollowPlayer : MonoBehaviour

    {

        [SerializeField] Transform target;
        [SerializeField] Vector3 offset;

        [SerializeField] float smoothSpeed = 0.125f;

        // Update is called once per frame
        void FixedUpdate()
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            transform.LookAt(target);
        }
    }
}

/*
//OG script (no rotation)
namespace TerraFirma.Camera
{
    public class CameraFollowPlayer : MonoBehaviour

    {

        [SerializeField] Transform target;
        [SerializeField] Vector3 offset;

        [SerializeField] float smoothSpeed = 0.125f;

        // Update is called once per frame
        void FixedUpdate()
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            transform.LookAt(target);
        }
    }
}

//New script with rotation
namespace TerraFirma.Camera
{
    public class CameraFollowPlayer : MonoBehaviour

    {

        [SerializeField] Transform target;
        [SerializeField] Vector3 offset;

        [SerializeField] float smoothSpeed = 0.125f;

        public CharacterController controller;

        public float turnSmoothTime = 0.1f;
        private float turnSmoothVelocity;

        // Update is called once per frame
        void FixedUpdate()
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            transform.LookAt(target);

            Vector3 direction = new Vector3(target.transform.position.x, target.transform.position.z).normalized;

            if (direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + target.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                controller.Move(moveDirection.normalized * smoothSpeed * Time.deltaTime);
            }
        }
    }
}
*/