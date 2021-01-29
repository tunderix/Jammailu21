using UnityEngine;
using System.Collections;

namespace TerraFirma.InspirationSystem
{
    public class InspirationTrigger : MonoBehaviour
    {
        [SerializeField] private int inspirationChange;
        [SerializeField] private float tickTimer;

        private InspirationResponder _responder
        {
            get => _responder;
            set => _responder = value;
        }

        private void Awake()
        {
            _responder = null;
        }

        private void OnTriggerEnter(Collider other)
        {
            _responder = other.gameObject.GetComponent<InspirationResponder>();
            StartCoroutine(InspirationModification());
        }

        private void OnTriggerExit(Collider other)
        {
            _responder = null;
            StopCoroutine(InspirationModification());
        }

        private IEnumerator InspirationModification()
        {
            yield return new WaitForSeconds(tickTimer);
            if (_responder != null) _responder.ModifyInspiration(inspirationChange);
        }
    }
}
