using UnityEngine;

namespace TerraFirma.Environment
{
    public class EnvironmentObserver : MonoBehaviour
    {
        private ITerraBlock anchoredBlock;
        [SerializeField] private StartPositionBlock startBlock;
        [SerializeField] private float distanceToAnchoredBlock;
        [SerializeField] private EnvironmentController environmentController;

        private void Awake()
        {
            anchoredBlock = startBlock;
            environmentController.RegisterObserver(this);
        }

        private void Update()
        {
            distanceToAnchoredBlock = Vector3.Distance(this.transform.position, anchoredBlock.Position);
        }

        public float DistanceToAnchor { get => distanceToAnchoredBlock; }

        public void SetAnchor(ITerraBlock to)
        {
            anchoredBlock = to;
        }
    }
}
