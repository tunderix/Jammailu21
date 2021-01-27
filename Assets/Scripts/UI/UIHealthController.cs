using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


namespace TerraFirma.UI
{
    public class UIHealthController : MonoBehaviour
    {
        TextMeshProUGUI healthTextGUI;

        // Start is called before the first frame update
        void Start()
        {
            healthTextGUI = gameObject.GetComponent<TextMeshProUGUI>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void UpdateHealth(int currentHealth, int maxHealth)
        {
            UpdateHealthBar(currentHealth, maxHealth);
            UpdateHealthText(currentHealth);
        }

        private void UpdateHealthBar(int currentHealth, int maxHealth)
        {

        }

        private void UpdateHealthText(int currentHealth)
        {
            healthTextGUI.text = currentHealth.ToString();
        }


    }
}
