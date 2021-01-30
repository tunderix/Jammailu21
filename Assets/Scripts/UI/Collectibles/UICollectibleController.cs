using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TerraFirma.UI
{
    public class UICollectibleController : MonoBehaviour
    {

        public Ice ice;
        public Cream cream;
        public Sugar sugar;

        public void UpdateCollectibles(int iceAmount, int creamAmount, int sugarAmount)
        {
            UpdateIce(iceAmount);
            UpdateCream(creamAmount);
            UpdateSugar(sugarAmount);
        }

        private void UpdateIce(int newAmount)
        {
            ice.SetAmount(newAmount);
        }

        private void UpdateCream(int newAmount)
        {
            cream.SetAmount(newAmount);
        }

        private void UpdateSugar(int newAmount)
        {
            sugar.SetAmount(newAmount);
        }


    }
}
