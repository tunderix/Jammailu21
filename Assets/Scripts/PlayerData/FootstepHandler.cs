using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class FootstepHandler : MonoBehaviour
    {
        [SerializeField] private Animator animator;
        [SerializeField] private Transform rBone;
        [SerializeField] private Transform lBone;
        public void FootStepEvent(AnimationEvent animationEvent){
        if(animationEvent.stringParameter == "Right"){
        GameObject.Instantiate(animationEvent.objectReferenceParameter, rBone.position,new Quaternion(0,0,0,0));
        }
        if(animationEvent.stringParameter == "Left"){
        GameObject.Instantiate(animationEvent.objectReferenceParameter, lBone.position,new Quaternion(0,0,0,0));
        }
    }
}
}
