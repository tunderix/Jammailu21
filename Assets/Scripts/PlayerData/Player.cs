using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace TerraFirma
{
    [System.Serializable]
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerHealthController healthController;
        public Apple apple;
        [SerializeField] private int healthInitial;
        //public Text currentHealthLabel;
        //public Image deadScreen;
        [SerializeField] private bool isDead;

        void Start()
        {
            healthController = new PlayerHealthController(healthInitial);
            isDead = false;
            //updateGUI();
        }

        void UpdateGUI()
        {
            //currentHealthLabel.text = currentHealth.ToString();
            //deadScreen.gameObject.SetActive(isDead);
        }

        private void GoToDeadScreen()
        {
            SceneManager.LoadScene("deadScreen", LoadSceneMode.Additive);
        }

        public bool TakeDamage(int damageAmount)
        {
            return healthController.AlterHealth(damageAmount);
        }

        public bool Heal(int healAmount)
        {
            return healthController.AlterHealth(healAmount);
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