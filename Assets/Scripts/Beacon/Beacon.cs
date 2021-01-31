using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class Beacon : MonoBehaviour
    {

        [SerializeField] private bool hasBeenTriggered;

        private void Start()
        {
            hasBeenTriggered = false;
        }
        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player == null) return;

            if (!hasBeenTriggered)
            {

                player.BeaconTriggered = true;

                hasBeenTriggered = true;
            }
        }
    }
}
