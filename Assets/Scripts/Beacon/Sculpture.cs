using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class Sculpture : MonoBehaviour
    {
        public bool piece1;
        [SerializeField] private Ship ship;

        [SerializeField] private GameObject sculpturePiece1Reference;
        [SerializeField] private GameObject sculpturePiece2Reference;
        [SerializeField] private GameObject sculpturePiece3Reference;

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
            }
        }
    }
}