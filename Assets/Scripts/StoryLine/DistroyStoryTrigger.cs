using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TerraFirma
{
    public class DistroyStoryTrigger : MonoBehaviour
    {
        [SerializeField] private StoryText storyText;
        [SerializeField] private StoryText storyText2;
        [SerializeField] private TextMeshPro storyComponent;

        [SerializeField] private float showTime;

        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                storyComponent.gameObject.SetActive(true);
                storyComponent.SetText(storyText.description);
                StartCoroutine(HideText());
            }
        }
        IEnumerator<WaitForSeconds> HideText()
        {
            yield return new WaitForSeconds(showTime);
            storyComponent.gameObject.SetActive(false);
            if (storyText2 != null)
            {
                StartCoroutine(ShowSecondText());
            }
            Destroy(gameObject);
        }

        IEnumerator<WaitForSeconds> ShowSecondText()
        {
            storyComponent.SetText(storyText2.description);
            storyComponent.gameObject.SetActive(true);
            yield return new WaitForSeconds(showTime);
        }

    }
}
