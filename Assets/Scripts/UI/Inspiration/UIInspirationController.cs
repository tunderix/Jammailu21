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

        // Start is called before the first frame update

        public void setupInspirationBar(int current, int max)
        {
            inspirationBar.SetUpInspiration(current, max);
        }

        public void UpdateInspiration(int value)
        {
            UpdateInspirationBar(value);
            if (value > 0)
            {
                UpdateInspirationText(value);
            }

        }

        private void UpdateInspirationBar(int value)
        {
            inspirationBar.SetInspiration(value);
        }

        private void UpdateInspirationText(int value)
        {
            GameObject Go = GameObject.Find("descriptionStory");
            if (Go == null) return;
            Go.SetActive(true);
            Go.GetComponent<TextMeshPro>().SetText("“Wow! I feel like I have found my long-lost inspiration finally. I want to start working on my masterpiece right now.”");
            StartCoroutine(HideText(Go));
        }
        IEnumerator<WaitForSeconds> HideText(GameObject Go)
        {
            yield return new WaitForSeconds(3);
            Go.SetActive(false);
        }
    }
}
