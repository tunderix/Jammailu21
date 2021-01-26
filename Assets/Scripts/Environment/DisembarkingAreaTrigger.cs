using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma.ParallaxMovement
{
    public class DisembarkingAreaTrigger : MonoBehaviour
    {
        [SerializeField] private UnityEngine.Camera ThirdPersonCamera;
        [SerializeField] private UnityEngine.Camera CameraFollowPlayer;
        private void setCameraActive(UnityEngine.Camera newCamera)
        {
            ThirdPersonCamera.gameObject.SetActive(false);
            CameraFollowPlayer.gameObject.SetActive(false);
            newCamera.gameObject.SetActive(true);
        }
        private void OnTriggerEnter(Collider other)
        {
            Player player = other.gameObject.GetComponent<Player>();
            if (player != null)
            {
                setCameraActive(CameraFollowPlayer);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            setCameraActive(ThirdPersonCamera);
        }
    }
}
