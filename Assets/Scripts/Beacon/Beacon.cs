using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class Beacon : MonoBehaviour
    {

        [SerializeField] private bool hasBeenTriggered;
        [SerializeField] private int beaconIndex;

        private void Start()
        {
            hasBeenTriggered = false;
        }
        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player == null) return;

            if (!hasBeenTriggered && beaconIndex != 0)
            {
                if (beaconIndex == 1) player.Beacon1Triggered = true;
                if (beaconIndex == 2) player.Beacon2Triggered = true;
                if (beaconIndex == 3) player.Beacon3Triggered = true;
                player.LaunchInspiredState(); // TODO - Should be based on inpiration value
                hasBeenTriggered = true;
            }
        }
    }
}
