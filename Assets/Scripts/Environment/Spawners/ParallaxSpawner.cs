using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace TerraFirma.ParallaxMovement
{
    [RequireComponent(typeof(Collider))]
    public class ParallaxSpawner : MonoBehaviour
    {
        [SerializeField] private List<ParallaxBehaviour> ObjectsToSpawn;
        [SerializeField] private float spawnFrequency;
        [SerializeField] private Ship ship;
        private bool spawningEnabled;

        private void Start()
        {
            spawningEnabled = true;
            StartCoroutine(MovingObjectSpawner());
        }


        private void Update()
        {
            if (ship.GetSpeed() == 0)
            {
                spawningEnabled = false;
            }
            else
            {
                spawningEnabled = true;
            }
        }

        private Collider _collider { get => this.GetComponent<Collider>(); }

        IEnumerator<WaitForSeconds> MovingObjectSpawner()
        {
            while (spawningEnabled)
            {
                Vector3 position = ParallaxHelpers.RandomPointInsideBounds(_collider.bounds);
                ParallaxBehaviour go = GameObject.Instantiate(ObjectsToSpawn.First(), position, Quaternion.identity);
                go.transform.SetParent(this.transform);
                yield return new WaitForSeconds(spawnFrequency);
            }
        }
    }
}
