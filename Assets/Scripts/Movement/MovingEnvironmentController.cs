using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace TerraFirma.ParallaxMovement
{
    public class MovingEnvironmentController : MonoBehaviour
    {
        [SerializeField] private List<ParallaxBehaviour> ObjectsToSpawn;
        [SerializeField] private float spawnFrequency;
        [SerializeField] private GameObject spawn;

        private void Start()
        {
            StartCoroutine(MovingObjectSpawner());
        }

        IEnumerator<WaitForSeconds> MovingObjectSpawner()
        {
            while (true)
            {
                ParallaxBehaviour go = GameObject.Instantiate(ObjectsToSpawn.First(), spawn.transform.position, Quaternion.identity);
                go.transform.SetParent(this.transform);
                yield return new WaitForSeconds(3);
            }
        }
    }
}
