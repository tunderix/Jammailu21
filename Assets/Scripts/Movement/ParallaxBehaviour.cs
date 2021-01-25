using UnityEngine;

namespace TerraFirma.ParallaxMovement
{
    public class ParallaxBehaviour : MonoBehaviour
    {
        protected Ship ship;

        [SerializeField] private bool movementEnabled;

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
            MoveShip();
        }
        

        protected void MoveShip()
        {
            if (!movementEnabled) return;

            Vector3 newPos = this.transform.position;
            newPos.x -= ship.GetSpeed() * Time.deltaTime;
            transform.SetPositionAndRotation(newPos, this.transform.rotation);
        }
    }
}
