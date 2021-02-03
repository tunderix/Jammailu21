using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TerraFirma
{
    public class TargetStoryLine : MonoBehaviour
    {
        public List<StoryText> materialSlogans = new List<StoryText>(3);
        private StoryText storyText;
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
            if (player != null)
            {
                storyText = materialSlogans[Random.Range(1, materialSlogans.Count)];
                if (storyComponent != null)
                {
                    storyComponent.gameObject.GetComponent<Renderer>().enabled = true;
                    storyComponent.SetText(storyText.description);
                    StartCoroutine(HideText());
                }
            }
        }
        IEnumerator<WaitForSeconds> HideText()
        {
            yield return new WaitForSeconds(showTime);
            if (storyComponent != null) storyComponent.gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
