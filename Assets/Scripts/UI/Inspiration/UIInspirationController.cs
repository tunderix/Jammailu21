using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


namespace TerraFirma.UI
{
    public class UIInspirationController : MonoBehaviour
    {
        [SerializeField] InspirationText inspirationText;
        [SerializeField] InspirationFill inspirationBar;

        // Start is called before the first frame update

        public void setupInspirationBar(int current, int max)
        {
            inspirationBar.SetUpInspiration(current, max);
        }

        public void UpdateInspiration(int value)
        {
            UpdateInspirationBar(value);
            UpdateInspirationText(value);
        }

        private void UpdateInspirationBar(int value)
        {
            inspirationBar.SetInspiration(value);
        }

        private void UpdateInspirationText(int value)
        {

        }


    }
}
