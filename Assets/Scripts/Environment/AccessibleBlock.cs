using UnityEngine;

namespace TerraFirma.Environment
{
    public class AccessibleBlock : MonoBehaviour, ITerraBlock
    {
        private bool _hasBeenUsedForGeneration = false;

        public bool IsAccessible { get => true; }

        public Vector3 Position { get => this.transform.position; }

        public bool hasBeenUsedForGeneration { get => _hasBeenUsedForGeneration; set { _hasBeenUsedForGeneration = value; } }
    }
}
