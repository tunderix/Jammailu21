using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TerraFirma.UI;
using TerraFirma.Collection;
using TerraFirma.InspirationSystem;

namespace TerraFirma
{
    [System.Serializable]
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerHealthController healthController;
        public int apples;
        [SerializeField] private UIHealthController uiHealthController;

        [SerializeField] private UICollectibleController uiCollectibleController;

        [SerializeField] private UIInspirationController uiInspirationController;

        [SerializeField] private InspirationResponder inspirationResponder;

        public Apple apple;
        [SerializeField] private int healthInitial;
        //public Text currentHealthLabel;
        //public Image deadScreen;
        [SerializeField] private bool isDead;

        [SerializeField] private CollectionController collectionController;

        [SerializeField] private List<WinCondition> winConditions;

        public bool BeaconTriggered;
        public WinCondition ApplecountWincondition;
        void Start()
        {
            healthController = new PlayerHealthController(healthInitial);
            collectionController = new CollectionController();

            isDead = false;
            SetupWinconditions();
            uiHealthController.setupHealthBar(healthInitial);
            uiInspirationController.setupInspirationBar(inspirationResponder.InspirationController.CurrentInspiration, inspirationResponder.InspirationController.MaxInspiration);

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

            if (Input.GetKeyDown(KeyCode.R)) collectionController.Gather();
            if (Input.GetKeyDown(KeyCode.T)) inspirationResponder.ModifyInspiration(50);

        }

        private void OnGUI()
        {
            uiHealthController.UpdateHealth(healthController.getHealth());
            uiCollectibleController.UpdateCollectibles(collectionController.Ice, collectionController.Cream, collectionController.Sugar);
            uiInspirationController.UpdateInspiration(inspirationResponder.InspirationController.CurrentInspiration);
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

        public void SetCollectableMaterial(CollectableMaterial _collectable)
        {
            collectionController.currentCollectableMaterial = _collectable;
        }

        public void LaunchInspiredState()
        {
            inspirationResponder.InspirationController.LaunchInspiredState(true);
        }
    }
}