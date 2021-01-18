using UnityEngine;

namespace TerraFirma.Environment
{
    [System.Serializable]
    public class StartPositionBlock : MonoBehaviour, ITerraBlock
    {
        public bool IsAccessible { get => true; }

        public Vector3 Position { get => this.transform.position; }
    }
}
