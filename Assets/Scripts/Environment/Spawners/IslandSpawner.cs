using UnityEngine;

namespace TerraFirma
{
    public class IslandSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject islandPrefab;


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                InstantiateIsland();
            }
        }

        public void InstantiateIsland()
        {
            GameObject newGameobject = GameObject.Instantiate(islandPrefab, this.transform.position, Quaternion.identity);
        }
    }
}
