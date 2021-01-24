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

        private void Start()
        {
            StartCoroutine(MovingObjectSpawner());
        }

        private Collider _collider { get => this.GetComponent<Collider>(); }

        IEnumerator<WaitForSeconds> MovingObjectSpawner()
        {
            while (true)
            {
                Vector3 position = ParallaxHelpers.RandomPointInsideBounds(_collider.bounds);
                ParallaxBehaviour go = GameObject.Instantiate(ObjectsToSpawn.First(), position, Quaternion.identity);
                go.transform.SetParent(this.transform);
                yield return new WaitForSeconds(3);
            }
        }
    }
}
