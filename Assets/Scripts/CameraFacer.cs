using UnityEngine;

namespace TerraFirma
{
    public class CameraFacer : MonoBehaviour
    {
        [SerializeField] private Transform cameraTransform;
        [SerializeField] private Vector3 rotationOffset;

        private void LateUpdate()
        {
            this.transform.LookAt(cameraTransform);
        }
    }
}
