using UnityEngine;

namespace TerraFirma.Environment
{
    public class InaccessibleBlock : MonoBehaviour, ITerraBlock
    {
        public bool IsAccessible { get => false; }

        public Vector3 Position { get => this.transform.position; }
    }
}
