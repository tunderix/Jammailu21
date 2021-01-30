using UnityEngine;
using System.Collections;

namespace TerraFirma.InspirationSystem
{
    public class InspirationTrigger : MonoBehaviour
    {
        [SerializeField] private int inspirationChange;
        [SerializeField] private float tickTimer;
        [SerializeField] private bool singleTime;

        private InspirationResponder _responder;

        private void Awake()
        {
            _responder = null;
        }

        private void OnTriggerEnter(Collider other)
        {
            _responder = other.gameObject.GetComponent<InspirationResponder>();
            if (singleTime) InspirationModification();
            else StartCoroutine(InspirationModification());
        }

        private void OnTriggerExit(Collider other)
        {
            _responder = null;
            StopCoroutine(InspirationModification());
        }

        private IEnumerator InspirationModification()
        {
            while (_responder != null)
            {
                _responder.ModifyInspiration(inspirationChange);
                yield return new WaitForSeconds(tickTimer);
            }
        }
    }
}
