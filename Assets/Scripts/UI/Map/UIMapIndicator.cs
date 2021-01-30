using UnityEngine;

namespace TerraFirma.UI
{
    public class UIMapIndicator : MonoBehaviour
    {
        public void SetLocation(Vector3 position)
        {
            RectTransform rect = this.GetComponent<RectTransform>();
            rect.anchoredPosition = position;
        }
    }
}
