using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class ForwardDirection
    {
        public static Vector2 DirectionVector2(Vector2 direction){
        return new Vector2(direction.x,-direction.y);
    }

        public static Vector3 DirectionVector3(Vector3 direction){
        return new Vector3(direction.y, 0,direction.x);
    }

    }
}
