using UnityEngine;

namespace TerraFirma.InspirationSystem
{
    [System.Serializable]
    public class InspirationController
    {
        [SerializeField] private int _currentInspiration;
        [SerializeField] private int _startInspiration;
        [SerializeField] private int inspiredStateRequirement;
        [SerializeField] private bool inspiredState;

        public int CurrentInspiration { get => _currentInspiration; }

        public int StartInspiration { get => _startInspiration; }




        public InspirationController(int startInspiration)
        {
            _startInspiration = startInspiration;
            _currentInspiration = startInspiration;
            inspiredState = false;
        }

        private bool _inspiredStateConditionsMet { get => _currentInspiration > inspiredStateRequirement; }

        public void ModifyInspiration(int amount)
        {
            _currentInspiration += amount;
            _currentInspiration = Mathf.Clamp(_currentInspiration, 0, _startInspiration);

            if (_inspiredStateConditionsMet) LaunchInspiredState();
        }

        private void LaunchInspiredState()
        {
            inspiredState = true;
        }
    }
}
