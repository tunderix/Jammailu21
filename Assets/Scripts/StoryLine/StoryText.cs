using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TerraFirma
{
    //Creating new object to Project list
    [CreateAssetMenu(fileName = "New Storyline", menuName = "StoryText")]
    public class StoryText : ScriptableObject
    {
        //can be called by StoryText.name
        public new string name;
        //can be called by StoryText.description
        public string description;

        public void Print()
        {
            Debug.Log(name + ":" + description);
        }
    }
}
