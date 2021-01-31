using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


namespace TerraFirma.UI
{
    public class UIInspirationController : MonoBehaviour
    {
        //[SerializeField] InspirationText inspirationText;
        [SerializeField] InspirationFill inspirationBar;
        /* private TextMeshPro storyComponent;
        [SerializeField] private StoryText storyText; */


        // Start is called before the first frame update

        public void setupInspirationBar(int current, int max)
        {
            inspirationBar.SetUpInspiration(current, max);
        }

        public void UpdateInspiration(int value)
        {
            Debug.Log(value);
            UpdateInspirationBar(value);
            /*  if (value >= 1000)
             {
                 UpdateInspirationText();
             } */

        }

        private void UpdateInspirationBar(int value)
        {
            inspirationBar.SetInspiration(value);
        }

        private void UpdateInspirationText()
        {
            /* TextMeshPro Go = GameObject.Find("descriptionStory").GetComponent<TextMeshPro>();
            Go.gameObject.SetActive(true);
            Go.SetText(storyText.description);
            StartCoroutine(HideText(Go.gameObject)); */
        }

    }
}
