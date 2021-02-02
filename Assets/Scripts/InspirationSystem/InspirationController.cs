using UnityEngine;

namespace TerraFirma.InspirationSystem
{
    [System.Serializable]
    public class InspirationController
    {
        [SerializeField] private int _currentInspiration;
        [SerializeField] private int _maxInspiration;
        [SerializeField] private int inspiredStateRequirement;
        [SerializeField] private bool inspiredState;

        public int CurrentInspiration { get => _currentInspiration; }

        public int MaxInspiration { get => _maxInspiration; }

        [SerializeField] private GameObject auraGameObject;


        public InspirationController(int startInspiration, int maxInspiration)
        {
            _maxInspiration = maxInspiration;
            _currentInspiration = startInspiration;
            inspiredState = false;
        }

        private bool _inspiredStateConditionsMet { get => _currentInspiration > inspiredStateRequirement; }

        public void ModifyInspiration(int amount)
        {
            _currentInspiration += amount;
            _currentInspiration = Mathf.Clamp(_currentInspiration, 0, _maxInspiration);

            LaunchInspiredState(_inspiredStateConditionsMet);
        }

        public void LaunchInspiredState(bool inspired)
        {
            if (inspired && auraGameObject != null) auraGameObject.SetActive(true);

            inspiredState = inspired;
        }

        public void LoseInspiredState()
        {
            auraGameObject.SetActive(false);
        }
    }
}
