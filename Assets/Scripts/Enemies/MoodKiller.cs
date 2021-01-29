using UnityEngine;

namespace TerraFirma.InspirationSystem
{
    public class MoodKiller : MonoBehaviour
    {
        public void Interact()
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
