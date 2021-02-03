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
                storyComponent.gameObject.GetComponent<Renderer>().enabled = true;
                storyComponent.SetText(storyText.description);
                StartCoroutine(HideText());
            }
        }
        IEnumerator<WaitForSeconds> HideText()
        {
            yield return new WaitForSeconds(showTime);
            if (storyComponent != null) storyComponent.gameObject.GetComponent<Renderer>().enabled = false;
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
            storyComponent.gameObject.GetComponent<Renderer>().enabled = true;
            yield return new WaitForSeconds(showTime);
            if (storyComponent != null) storyComponent.gameObject.GetComponent<Renderer>().enabled = false;

            GameObject whiteTextGameObject = GameObject.Find("StoryTextWhite");

            if (storyText3 != null && whiteTextGameObject != null)
            {
                storyComponent = whiteTextGameObject.GetComponent<TextMeshPro>();
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
            storyComponent.gameObject.GetComponent<Renderer>().enabled = true;
            yield return new WaitForSeconds(5);
            if (storyComponent != null) storyComponent.gameObject.GetComponent<Renderer>().enabled = false;
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
            storyComponent.gameObject.GetComponent<Renderer>().enabled = true;
            yield return new WaitForSeconds(5);
            storyComponent.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }

    }
}
