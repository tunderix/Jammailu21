using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TerraFirma
{
    public class DestroyBeginningStory : MonoBehaviour
    {
        [SerializeField] private StoryText storyText;
        [SerializeField] private StoryText storyText2;
        [SerializeField] private StoryText storyText3;
        [SerializeField] private StoryText storyText4;
        private TextMeshPro storyComponent;

        [SerializeField] private float showTime;

        private void Awake()
        {
            //storyComponent = GameObject.Find("moodkillersText").GetComponent<TextMeshPro>();
        }

        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                storyComponent = GameObject.Find("StoryTextBlack").GetComponent<TextMeshPro>();
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
                storyComponent = GameObject.Find("StoryTextBlack").GetComponent<TextMeshPro>();
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        IEnumerator<WaitForSeconds> ShowSecondText()
        {
            storyComponent.SetText(storyText2.description);
            storyComponent.gameObject.SetActive(true);
            yield return new WaitForSeconds(showTime);
            storyComponent.gameObject.SetActive(false);
            if (storyText3 != null)
            {
                storyComponent = GameObject.Find("StoryTextWhite").GetComponent<TextMeshPro>();
                StartCoroutine(ShowThirdText());
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        IEnumerator<WaitForSeconds> ShowThirdText()
        {
            storyComponent.SetText(storyText3.description);
            storyComponent.gameObject.SetActive(true);
            yield return new WaitForSeconds(7);
            storyComponent.gameObject.SetActive(false);
            if (storyText4 != null)
            {
                StartCoroutine(ShowFourthText());
                storyComponent = GameObject.Find("StoryTextWhite").GetComponent<TextMeshPro>();
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        IEnumerator<WaitForSeconds> ShowFourthText()
        {
            storyComponent.SetText(storyText4.description);
            storyComponent.gameObject.SetActive(true);
            yield return new WaitForSeconds(7);
            storyComponent.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }

    }
}
