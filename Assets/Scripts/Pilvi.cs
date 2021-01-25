using UnityEngine;

namespace TerraFirma.ParallaxMovement
{
    public class Pilvi : ParallaxBehaviour, IParallaxMove
    {
        [SerializeField] private float speedVariance;
        public float SpeedVariance { get => speedVariance; }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name == "Despawner") GameObject.Destroy(this.gameObject);
        }
    }
}
