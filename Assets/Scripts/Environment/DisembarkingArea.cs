using UnityEngine;

namespace TerraFirma.ParallaxMovement
{
    public class DisembarkingArea : ParallaxBehaviour, IParallaxMove
    {
        [SerializeField] private float speedVariance;
        public float SpeedVariance { get => speedVariance; }

        private void Start()
        {
            ship = (Ship)GameObject.Find("Ship").GetComponent<Ship>();
            this.SetMovementEnabled(true);
            ship.AnchorDown();
        }

        private void Update()
        {
            MoveShip();
        }
    }
}
