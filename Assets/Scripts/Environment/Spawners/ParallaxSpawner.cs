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
        [SerializeField] private float objectSpeedModifier;
        [SerializeField] private float objectMinimumSpeed;

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
                go.ElevationSpeedModifier = ElevationSpeedModifier();
                go.transform.SetParent(this.transform);
                yield return new WaitForSeconds(3);
            }
        }

        private float ElevationSpeedModifier()
        {
            float modifier = objectSpeedModifier * this.transform.localPosition.y;
            return modifier < objectMinimumSpeed ? objectMinimumSpeed : modifier;
        }
    }
}
