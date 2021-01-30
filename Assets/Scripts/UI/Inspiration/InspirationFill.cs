using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace TerraFirma.UI
{
    public class InspirationFill : MonoBehaviour
    {
        [SerializeField] private Image image;
        private int maxInspiration;
        // Start is called before the first frame update
        public void SetUpInspiration(int initial, int max)
        {
            maxInspiration = max;
            image.fillAmount = initial / max;
        }

        public void SetInspiration(int value)
        {
            image.fillAmount = value / maxInspiration;
        }

    }
}
