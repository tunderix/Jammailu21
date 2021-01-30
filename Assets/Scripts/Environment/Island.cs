using UnityEngine;

namespace TerraFirma.ParallaxMovement
{
    public class Island : ParallaxBehaviour
    {
        private void Start()
        {
            ship = (Ship)GameObject.Find("Ship").GetComponent<Ship>();
            this.SetMovementEnabled(true);
        }
    }
}
