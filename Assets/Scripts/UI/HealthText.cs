using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace TerraFirma.UI
{
    public class HealthText : MonoBehaviour
    {
        public TextMeshProUGUI healthTextGUI;

        // Start is called before the first frame update
        void Start()
        {

        }

        public void SetHealth(int health)
        {
            healthTextGUI.text = health.ToString();
        }
    }
}
