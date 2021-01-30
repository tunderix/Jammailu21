using UnityEngine;

namespace TerraFirma.InspirationSystem
{
    public class InspirationResponder : MonoBehaviour
    {
        [SerializeField] private InspirationController inspirationController;
        [SerializeField] private int startInspiration;
        [SerializeField] private int maxInspiration;

        public InspirationController InspirationController { get => inspirationController; set => inspirationController = value; }

        private void Awake()
        {
            inspirationController = new InspirationController(startInspiration, maxInspiration);
        }

        public void ModifyInspiration(int value)
        {
            inspirationController.ModifyInspiration(value);
        }
    }
}
