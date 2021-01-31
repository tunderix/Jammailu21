using UnityEngine;
using System.Collections.Generic;

namespace TerraFirma
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] float speed;
        [SerializeField] float decelerationModifier;
        private float maxSpeed;
        [SerializeField] private IslandSpawner islandSpawner;

        private bool anchorIsDown;

        private void Start()
        {
            anchorIsDown = false;
            maxSpeed = speed;
        }

        private void Update()
        {
            if (anchorIsDown)
            {
                speed -= 0.5f * decelerationModifier * Time.deltaTime;
            }
            else
            {
                speed += 0.5f * decelerationModifier * Time.deltaTime;
                if (speed > maxSpeed) speed = maxSpeed;
            }

            if (speed <= 0f)
            {
                speed = 0f;
                if (Input.GetKeyDown(KeyCode.X))
                {
                    anchorIsDown = false;
                }
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
        public void AnchorUp()
        {
            anchorIsDown = false;
            StartCoroutine(SpawnNextIsland());
        }

        IEnumerator<WaitForSeconds> SpawnNextIsland()
        {
            yield return new WaitForSeconds(20);
            islandSpawner.InstantiateIsland();
        }
    }
}
