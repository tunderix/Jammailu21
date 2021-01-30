using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace TerraFirma.UI
{
    public class HealthText : MonoBehaviour
    {
        public TextMeshProUGUI _text;

        // Start is called before the first frame update
        void Start()
        {

        }

        public void SetHealth(int health)
        {
            _text.text = health.ToString();
        }
    }
}
