using UnityEngine;

namespace TerraFirma.Environment
{
    public interface ITerraBlock
    {
        public bool IsAccessible { get; }
        public Vector3 Position { get; }
    }
}
