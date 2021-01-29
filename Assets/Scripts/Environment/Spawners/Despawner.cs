using UnityEngine;

namespace TerraFirma.ParallaxMovement
{
    public class Despawner : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Pilvi pilvi = other.GetComponent<Pilvi>();
            if (pilvi != null) GameObject.Destroy(other.gameObject);
        }
    }
}
