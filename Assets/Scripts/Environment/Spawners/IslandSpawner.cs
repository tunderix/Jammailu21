using UnityEngine;

namespace TerraFirma
{
    public class IslandSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject islandPrefab;
        [SerializeField] private GameObject islandPrefab2;
        [SerializeField] private GameObject islandPrefab3;

        private void Start()
        {
            InstantiateIsland(3);
        }

        private void Update()
        {

        }

        public void InstantiateIsland(int i)
        {
            GameObject prefabToSpawn = islandPrefab;
            if (i == 2) prefabToSpawn = islandPrefab2;
            if (i == 3) prefabToSpawn = islandPrefab3;

            GameObject newGameobject = GameObject.Instantiate(prefabToSpawn, this.transform.position, Quaternion.identity);
        }
    }
}
