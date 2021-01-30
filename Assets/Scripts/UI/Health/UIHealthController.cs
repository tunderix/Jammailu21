using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


namespace TerraFirma.UI
{
    public class UIHealthController : MonoBehaviour
    {
        public HealthText healthText;
        public HealthBar healthBar;

        // Start is called before the first frame update

        public UIHealthController(int initialHealth)
        {
            setupHealthBar(initialHealth);
        }
        void Start()
        {
            //   healthTextGUI = gameObject.GetComponent<TextMeshProUGUI>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void setupHealthBar(int maxHealth)
        {
            healthBar.SetMaxHealth(maxHealth);
        }

        public void UpdateHealth(int currentHealth)
        {
            UpdateHealthBar(currentHealth);
            UpdateHealthText(currentHealth);
        }

        private void UpdateHealthBar(int currentHealth)
        {
            healthBar.SetHealth(currentHealth);
        }

        private void UpdateHealthText(int currentHealth)
        {
            healthText.SetHealth(currentHealth);
        }


    }
}
