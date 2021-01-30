using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace TerraFirma.UI
{
    public class InspirationFill : MonoBehaviour
    {
        [SerializeField] private Image image;
        [SerializeField] private int maxInspiration;
        [SerializeField] private int CurrentInspiration;
        // Start is called before the first frame update
        public void SetUpInspiration(int current, int max)
        {
            CurrentInspiration = current;
            maxInspiration = max;


            image.fillAmount = (float)current / (float)max;

        }

        public void SetInspiration(int value)
        {
            image.fillAmount = (float)value / (float)maxInspiration;
        }

    }
}
