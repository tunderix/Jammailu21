using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

namespace TerraFirma
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] float speed;
        [SerializeField] float decelerationModifier;
        private float maxSpeed;
        [SerializeField] private IslandSpawner islandSpawner;
        private int islandToSpawnIndex = 0;

        //public Text shipText;
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
            if (anchorIsDown == true)
            {
                UpdateShipText();
            }
        }
        public void AnchorUp()
        {
            anchorIsDown = false;
            islandToSpawnIndex++;
            StartCoroutine(SpawnNextIsland());
        }

        IEnumerator<WaitForSeconds> SpawnNextIsland()
        {
            yield return new WaitForSeconds(20);
            islandSpawner.InstantiateIsland(islandToSpawnIndex);
        }

        private void UpdateShipText()
        {
            GameObject Go = GameObject.Find("descriptionStory");
            Go.SetActive(true);
            Go.GetComponent<TextMeshPro>().SetText("“What is happening!? My ship is stopping. I need to find some fuel... and fast! I need to get the old boy running again. Perhaps there is something nearby that I could harvest.”");
            StartCoroutine(HideText(Go));
        }
        IEnumerator<WaitForSeconds> HideText(GameObject Go)
        {
            yield return new WaitForSeconds(3);
            Go.SetActive(false);
}
        }
    }
