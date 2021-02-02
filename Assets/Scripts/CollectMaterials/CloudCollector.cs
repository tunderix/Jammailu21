using UnityEngine;

namespace TerraFirma.Collection
{
    public class CloudCollector : MonoBehaviour
    {
        [SerializeField] private bool _canSuckClouds;
        [SerializeField] private SuckableCloudArea suckableCloudArea;
        [SerializeField] private Player player;

        private void Awake()
        {
            _canSuckClouds = false;
        }

        private void Update()
        {
            if (_canSuckClouds && Input.GetKeyDown(KeyCode.R))
            {
                SuckCloud();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            _canSuckClouds = other.GetComponent<Player>() != null;
        }

        private void SuckCloud()
        {
            if (suckableCloudArea.suckableCloud != null)
            {
                OnCloudSucked(suckableCloudArea.suckableCloud);
            }
        }

        private void OnCloudSucked(SuckableCloud suckableCloud)
        {
            suckableCloud.Destroy();
            player.AddCloud();
        }
    }
}
