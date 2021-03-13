using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class LookDirection
    {
    public static Quaternion LookDirectionVector(Vector2 direction){


        Quaternion rotation = Quaternion.Euler(Mathf.Rad2Deg*Mathf.Acos(-direction.normalized.y),0,Mathf.Rad2Deg*Mathf.Acos(direction.normalized.x));

        //Debug.Log("y"+Mathf.Rad2Deg*Mathf.Acos(-direction.normalized.y));
        //Debug.Log("x"+Mathf.Rad2Deg*Mathf.Acos(direction.normalized.x));
        //Debug.Log("rot"+rotation);
        //Vector3 test = new Vector3(-direction.y, 0, direction.x);
        //Vector3 forward = test
        //float angle = Vector3.SignedAngle(new Vector3(-direction.y, 0, direction.x),whatisforward,Vector3.up);
        
        return rotation;
    }

    }
}