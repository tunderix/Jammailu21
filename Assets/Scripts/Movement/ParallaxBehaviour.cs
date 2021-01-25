using UnityEngine;

namespace TerraFirma.ParallaxMovement
{
    public class ParallaxBehaviour : MonoBehaviour
    {
        protected Ship ship;

        [SerializeField] private bool movementEnabled;

        private float _speedModifier;
        public float ElevationSpeedModifier
        {
            get => _speedModifier;
            set
            {
                _speedModifier = value;
            }
        }

        private void Start()
        {
            ship = (Ship)GameObject.Find("Ship").GetComponent<Ship>();
            movementEnabled = true;
        }

        protected void SetMovementEnabled(bool enabled)
        {
            this.movementEnabled = enabled;
        }

        private void Update()
        {
            MoveShip(_speedModifier);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name == "Despawner") GameObject.Destroy(this.gameObject);
        }

        protected void MoveShip()
        {
            if (!movementEnabled) return;

            Vector3 newPos = this.transform.position;
            newPos.x -= ship.GetSpeed() * Time.deltaTime;
            transform.SetPositionAndRotation(newPos, this.transform.rotation);
        }
        protected void MoveShip(float withSpeedModifier)
        {
            if (!movementEnabled) return;

            Vector3 newPos = this.transform.position;
            newPos.x -= ship.GetSpeed() * withSpeedModifier * Time.deltaTime;
            transform.SetPositionAndRotation(newPos, this.transform.rotation);
        }
    }
}
