using UnityEngine;

namespace TerraFirma
{
    public class CameraFacer : MonoBehaviour
    {
        [SerializeField] private Vector3 rotationOffset;
        private Transform _cameraTransform;

        private void Start()
        {
            _cameraTransform = GameObject.Find("CameraFollowTarget").transform;
        }

        private void LateUpdate()
        {
            this.transform.LookAt(_cameraTransform);
        }
    }
}
