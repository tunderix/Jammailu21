using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class PotionController : MonoBehaviour
    {
        [SerializeField] private int healAmount;

        private void OnCollisionWithPlayer(GameObject player)
        {
            PlayerHealthController playerHealthController = player.GetComponent<PlayerHealthController>();
            playerHealthController.Heal(healAmount);
        }
    }
}
