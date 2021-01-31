using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class Sculpture : MonoBehaviour
    {
        public bool piece1;
        [SerializeField] private Ship ship;

        private void Start()
        {
            piece1 = false;
        }
        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player == null) return;

            AddPiece(player);
        }

        public void AddPiece(Player player)
        {
            if (!piece1)
            {
                player.BeaconTriggered = false;
                ship.AnchorUp();
                piece1 = true;
            }
        }
    }
}