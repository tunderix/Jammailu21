using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    [System.Serializable]
    public class PlayerHealthController
    {
        [SerializeField] private int healthInitial;
        private int healthCurrent;

        public PlayerHealthController(int _healthInitial)
        {
            healthInitial = _healthInitial;
            setHealth(_healthInitial);
        }

        public void setHealth(int value)
        {
            healthCurrent = value;
        }

        void Start()
        {
            ResetHealth();
        }

        // Sets the player's current health back to its initial value
        public void ResetHealth()
        {
            healthCurrent = healthInitial;
        }

        //Call this if hit by enemy
        public void TakeDamage(int damageAmount)
        {
            healthCurrent -= damageAmount;

            if (healthCurrent <= 0)
            {
                //Kill player
                //Destroy(GameObject);
            }

            // NB: Here, you may want to restart the game
            // (e.g. by informing your game manager that the player has died,
            // or by raising an event using your event system)
        }

        // Increase the player's current health
        public void Heal(int healAmount)
        {
            healthCurrent += healAmount;

            if (healthCurrent > healthInitial)
            {
                ResetHealth();
            }
        }





        /*         
        OG SCRIPT BY SAMI  
        
        public PlayerHealthController(int minimumHealth)
                {
                    healthMinimum = minimumHealth;
                    setHealth(minimumHealth);
                }

                public void setHealth(int value)
                {
                    healthCurrent = value;
                }

                public int startHealth()
                {
                    if (healthCurrent < healthMinimum)
                        return healthMinimum;
                    else return healthCurrent;
                } */

    }
}
