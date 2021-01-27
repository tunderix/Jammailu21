using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TerraFirma.UI;

namespace TerraFirma
{
    [System.Serializable]
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerHealthController healthController;
        public int apples;
        [SerializeField] private UIHealthController uiController;

        public Apple apple;
        [SerializeField] private int healthInitial;
        //public Text currentHealthLabel;
        //public Image deadScreen;
        [SerializeField] private bool isDead;

        [SerializeField] private List<WinCondition> winConditions;
        public WinCondition ApplecountWincondition;
        void Start()
        {
            healthController = new PlayerHealthController(healthInitial);
            isDead = false;
            SetupWinconditions();
            //updateGUI();
            //WinCondition.count = 0;
            //WinCondition.winText.text = "";
            //WinCondition.SetCountText ();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                TakeDamage(1);
            }
        }

        private void OnGUI()
        {
            uiController.UpdateHealth(healthController.getHealth(), healthController.getHealthInitial());

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
            return healthController.AlterHealth(-damageAmount);
        }

        public bool Heal(int healAmount)
        {
            return healthController.AlterHealth(healAmount);
        }

        public void AddWincondition(WinCondition _winCondition)
        {
            winConditions.Add(_winCondition);
        }

        public void SetupWinconditions()
        {
            ApplecountWincondition = new WinCondition();
            //AddWincondition(collectApples);
        }

        public void PlayerGotApple(int count)
        {
            apples = apples + count;
            ApplecountWincondition.count = apples;
            //TODO Show victory in UI
            bool PlayerWonWithApples = ApplecountWincondition.CheckWinCondition();
        }
    }
}