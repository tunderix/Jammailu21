using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class Apple : MonoBehaviour
    {
        [SerializeField] private WinCondition winCondition;
        private float size;
        private bool hasBeenThrown;
        [SerializeField] private int count;

        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.PlayerGotApple(count);
                GameObject.Destroy(this.gameObject);
            }
        }

        public float getSize()
        {
            return size;
        }

        public bool getThrown()
        {
            return hasBeenThrown;
        }

    }
}
