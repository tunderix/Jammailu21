using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace TerraFirma.Environment
{
    public class EnvironmentController : MonoBehaviour
    {
        [SerializeField] private AccessibleBlock accessibleBlockPrefab;
        [SerializeField] private InaccessibleBlock inaccessibleBlockPrefab;
        [SerializeField] private List<EnvironmentObserver> environmentObservers;
        private EnvironmentObserver defaultObserver { get => environmentObservers != null ? environmentObservers.First() : null; }

        private void Awake()
        {
            environmentObservers = new List<EnvironmentObserver>();
        }

        private void Update()
        {
            if (!TimeToGenerateTerraBlock) return;
            if (!ObserverDemandsNewBlock) return;

            GenerateTerraBlock();
        }

        private bool TimeToGenerateTerraBlock
        {
            get
            {
                if (defaultObserver == null) return false;
                return true;
            }
        }
        private bool ObserverDemandsNewBlock
        {
            get
            {
                if (defaultObserver == null) return false;
                if (defaultObserver.DistanceToAnchor >= 30f)
                {
                    return true;
                }
                return false;
            }
        }
        private void GenerateTerraBlock()
        {
            if (defaultObserver == null) return;

            Vector3 terraBlockPosition = new Vector3(defaultObserver.transform.position.x * 2, defaultObserver.transform.position.y, defaultObserver.transform.position.z * 2);
            AccessibleBlock go = GameObject.Instantiate(accessibleBlockPrefab, terraBlockPosition, Quaternion.identity);
            environmentObservers.First().SetAnchor(go);
        }

        public bool RegisterObserver(EnvironmentObserver observer)
        {
            //TODO - Logic here for if its possible to add observers.
            environmentObservers.Add(observer);
            return true;
        }
    }
}
