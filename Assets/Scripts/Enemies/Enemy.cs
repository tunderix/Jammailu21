using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private int damagePerTrick;
        [SerializeField] private float damageTickTime;

        private List<Player> EnemyContact = new List<Player>();
        private float damageTickCooldown;

        void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                EnemyContact.Add(player);
                damageTickCooldown = 0.0f;
            }
        }

        void OnTriggerExit(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                EnemyContact.Remove(player);
            }
        }
        void Update()
        {
            if (EnemyContact.Count <= 0) return;

            if (damageTickCooldown <= 0.0f)
            {
                foreach (Player player in EnemyContact)
                //TODO
                {
                    bool playerIsDead = player.TakeDamage(-1 * damagePerTrick);
                }
                //start cooldown;
                damageTickCooldown = damageTickTime;
            }
            else
            {
                damageTickCooldown -= Time.deltaTime;
            }
        }
    }
}