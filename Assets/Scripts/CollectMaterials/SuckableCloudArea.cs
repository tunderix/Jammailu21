using UnityEngine;

namespace TerraFirma
{
    public class SuckableCloudArea : MonoBehaviour
    {
        public SuckableCloud suckableCloud;

        private void OnTriggerEnter(Collider other)
        {
            SuckableCloud cloud = other.GetComponent<SuckableCloud>();
            if (cloud != null)
            {
                suckableCloud = cloud;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            suckableCloud = null;
        }
    }
}
