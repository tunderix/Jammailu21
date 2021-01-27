using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    [System.Serializable]
    public class PlayerHealthController
    {
        private int healthInitial;
        [SerializeField] private int healthCurrent;

        public PlayerHealthController(int _healthInitial)
        {
            healthInitial = _healthInitial;
            ResetHealth();
        }

        public int getHealthInitial()
        {
            return healthInitial;
        }

        public int getHealth()
        {
            return healthCurrent;
        }

        public void setHealth(int value)
        {
            healthCurrent = value;
        }

        // Sets the player's current health back to its initial value
        public void ResetHealth()
        {
            healthCurrent = healthInitial;
        }

        //Call this if hit by enemy
        public bool TakeDamage(int damageAmount)
        {
            return AlterHealth(damageAmount);
        }

        // Increase the player's current health
        public bool Heal(int healAmount)
        {
            return AlterHealth(healAmount);
        }

        public bool AlterHealth(int amount)
        {
            healthCurrent += amount;
            healthCurrent = Mathf.Clamp(healthCurrent, 0, healthInitial);
            bool isDead = CheckDead();
            if (isDead)
            {
                //Here we know player is dead
                //GetComponent<Movement>().enabled = false;
            }
            return isDead;
        }


        private bool CheckDead()
        {
            if (healthCurrent < 1)
            {
                return true;
            }
            return false;
        }
    }
}
