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

namespace TerraFirma.Camera
{
    public class CameraFollowPlayer : MonoBehaviour

    {

        [SerializeField] GameObject target;
        [SerializeField] Vector3 offset;
        public float smoothSpeed = 0.125f;

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z) + offset;
        }
    }
}

*/