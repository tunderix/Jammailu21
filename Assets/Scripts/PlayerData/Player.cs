using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    [System.Serializable]
    public class Player
    {
        [SerializeField] private PlayerHealthController healthInitial;
        public Apple apple;
        [SerializeField] private int healthCurrent;
        //public Text currentHealthLabel;
        //public Image deadScreen;
        private bool isDead;

        void Start()
        {
            healthCurrent = new PlayerHealthController healthInitial;
            isDead = false;
            //updateGUI();
        }

        void UpdateGUI()
        {
            //currentHealthLabel.text = currentHealth.ToString();
            //deadScreen.gameObject.SetActive(isDead);
        }
        public void AlterHealth(int amount)
        {
            healthCurrent += amount;
            healthCurrent = Mathf.Clamp(healthCurrent, 0, healthInitial);
            CheckDead();
            UpdateGUI();
        }

        private void CheckDead()
        {
            //dont redo if already dead.
            if (isDead)
                return;
            if (healthCurrent == 0)
            {
                isDead = true;
                //GetComponent<Movement>().enabled = false;
            }
        }

    }
}
/*OG SCRIPT BY SAMI
namespace TerraFirma
{
    public class PlayerData : MonoBehaviour
    {

        [SerializeField] int healthInitial;
        [SerializeField] private PlayerHealthController healthCurrent;
        public Apple apple;
        private void Awake()
        {
            apple = new Apple();
            healthCurrent = new PlayerHealthController(healthInitial);
        }

        private void Update()
        {
            int Health = healthCurrent.healthInitial();
            Debug.Log("Health" + Health);
        }

        private void Start()
        {

        }

        public int getMinimumHealth()
        {
            return 0;
        }

        public bool appleHasBeenThrown()
        {
            return apple.getThrown();
        }
    }
}

*/