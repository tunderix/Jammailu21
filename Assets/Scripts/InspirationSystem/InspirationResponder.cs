using UnityEngine;

namespace TerraFirma.InspirationSystem
{
    public class InspirationResponder : MonoBehaviour
    {
        private InspirationController inspirationController;

        public InspirationController InspirationController { get => inspirationController; set => inspirationController = value; }

        public void ModifyInspiration(int value)
        {
            inspirationController.ModifyInspiration(value);
        }
    }
}
