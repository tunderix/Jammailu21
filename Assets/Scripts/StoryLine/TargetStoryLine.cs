using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TerraFirma
{
    public class TargetStoryLine : MonoBehaviour
    {
        [SerializeField] private StoryText storyText;
        [SerializeField] private StoryText storyText2;
        private TextMeshPro storyComponent;

        [SerializeField] private float showTime;

        private void Start()
        {
            GameObject descriptionStoryGameObject = GameObject.Find("descriptionStory");
            if (descriptionStoryGameObject != null)
            {
                storyComponent = descriptionStoryGameObject.GetComponent<TextMeshPro>();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player != null && storyComponent != null)
            {
                storyComponent.gameObject.SetActive(true);
                storyComponent.SetText(storyText.description);
                StartCoroutine(HideText());
            }
        }


        IEnumerator<WaitForSeconds> HideText()
        {
            yield return new WaitForSeconds(showTime);

            if (storyComponent != null) storyComponent.gameObject.SetActive(false);

            if (storyText2 != null)
            {
                StartCoroutine(ShowSecondText());
            }
        }

        IEnumerator<WaitForSeconds> ShowSecondText()
        {
            if (storyComponent != null)
            {
                storyComponent.SetText(storyText2.description);
                storyComponent.gameObject.SetActive(true);
            }

            yield return new WaitForSeconds(showTime);

            if (storyComponent != null) storyComponent.gameObject.SetActive(false);
        }
    }
}
