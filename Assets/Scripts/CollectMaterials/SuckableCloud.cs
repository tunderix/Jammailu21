using UnityEngine;

namespace TerraFirma
{
    public class SuckableCloud : MonoBehaviour
    {
        public void Destroy()
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
