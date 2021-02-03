using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class Sculpture : MonoBehaviour
    {
        public bool piece1;
        public bool piece2;
        public bool piece3;

        [SerializeField] private Ship ship;

        [SerializeField] private GameObject sculpturePiece1Reference;
        [SerializeField] private GameObject sculpturePiece2Reference;
        [SerializeField] private GameObject sculpturePiece3Reference;

        private void Start()
        {
            piece1 = false;
            piece2 = false;
            piece3 = false;
        }

        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player == null) return;

            if (player.collectionController.Ice >= 2 && player.collectionController.Sugar >= 2 && player.collectionController.Cream >= 2)
            {
                CompareBeaconPieces(piece1, player.Beacon1Triggered, sculpturePiece1Reference);
                CompareBeaconPieces(piece2, player.Beacon2Triggered, sculpturePiece2Reference);
                CompareBeaconPieces(piece3, player.Beacon3Triggered, sculpturePiece3Reference);

                player.collectionController.DrainAll(2);
            }


        }

        private void CompareBeaconPieces(bool i, bool j, GameObject go)
        {
            if (i != j)
            {
                i = j;
                ship.AnchorUp();
            }
            go.SetActive(i);
        }
    }
}