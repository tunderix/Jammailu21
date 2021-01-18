using UnityEngine;

namespace TerraFirma.Environment
{
    public class AccessibleBlock : MonoBehaviour, ITerraBlock
    {
        public bool IsAccessible { get => true; }

        public Vector3 Position { get => this.transform.position; }
    }
}
