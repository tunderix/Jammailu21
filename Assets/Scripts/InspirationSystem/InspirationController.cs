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

        public int StartInspiration { get => _maxInspiration; }




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

            if (_inspiredStateConditionsMet) LaunchInspiredState();
        }

        private void LaunchInspiredState()
        {
            inspiredState = true;
        }
    }
}
