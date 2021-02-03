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
        private TextMeshPro storyComponent;

        [SerializeField] private float showTime;

        private void Start()
        {
            GameObject descrGameObject = GameObject.Find("descriptionStory");
            if (descrGameObject != null)
            {
                storyComponent = descrGameObject.GetComponent<TextMeshPro>();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
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
            Destroy(this.gameObject);
        }

    }
}
