using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace TerraFirma
{
    public class StoryDisplay : MonoBehaviour
    {
        public StoryText storyText;

        // Start is called before the first frame update
        void Start()
        {
            this.GetComponent<TextMeshPro>().text = storyText.description;
            //storyText.Print();
            //nameText.text = storyText.name;
            //descriptionText.text = storyText.description;
        }

    }
}
