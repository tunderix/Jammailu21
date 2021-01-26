using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class HealthPickup : MonoBehaviour
    {
        public int healAmount = 10;

        void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                player.Heal(healAmount);
                gameObject.SetActive(false);
            }
        }
    }
}
