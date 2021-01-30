using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace TerraFirma
{
    public class Sugar : MonoBehaviour
    {
        public TextMeshProUGUI _text;

        // Start is called before the first frame update
        void Start()
        {

        }

        public void SetAmount(int amount)
        {

            _text.text = amount.ToString();
        }
    }
}
