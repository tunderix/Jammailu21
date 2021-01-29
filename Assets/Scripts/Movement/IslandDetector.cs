using UnityEngine;

namespace TerraFirma.ParallaxMovement
{
    public class IslandDetector : MonoBehaviour
    {
        [SerializeField] private Ship ship;
        private void OnTriggerEnter(Collider other)
        {
            Island island = other.transform.GetComponent<Island>();
            if (island != null)
            {
                ship.AnchorDown();
            }
        }
    }
}
