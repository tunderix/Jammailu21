using UnityEngine;

namespace TerraFirma
{
    [System.Serializable]
    public class MapRoute
    {
        [SerializeField] public Vector3 StartPosition;
        [SerializeField] public Vector3 TargetPosition;
        [SerializeField] private float timeScale;
        public MapRoute()
        {
            timeScale = 4;
        }

        public float TotalTravelTime()
        {
            return Vector3.Distance(StartPosition, TargetPosition) * timeScale;
        }
    }
}
