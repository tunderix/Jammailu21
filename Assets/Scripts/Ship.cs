using UnityEngine;
using UnityEngine.AI;

namespace TerraFirma
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] float speed;

        private bool anchorIsDown;

        private void Start()
        {
            anchorIsDown = false;

        }

        private void Update()
        {
            if (anchorIsDown)
            {
                speed -= 0.5f * Time.deltaTime;
            }
            if (speed <= 0f)
            {
                speed = 0f;
            }
        }

        public float GetSpeed()
        {
            return this.speed;
        }

        public void AnchorDown()
        {
            anchorIsDown = true;
        }
    }
}
