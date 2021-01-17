using UnityEngine;

namespace TerraFirma.Movement
{
    public static class MoveDirection
    {
        public static Vector3 Left { get { return new Vector3(-1, 0, 0); } }
        public static Vector3 Right { get { return new Vector3(1, 0, 0); } }
        public static Vector3 Up { get { return new Vector3(0, 0, 1); } }
        public static Vector3 Down { get { return new Vector3(0, 0, -1); } }
        public static Vector3 Sky { get { return new Vector3(0, 1, 0); } }
        public static Vector3 Hell { get { return new Vector3(0, -1, 0); } }
    }
}
