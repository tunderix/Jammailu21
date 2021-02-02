using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TerraFirma
{
    public class MoodkillersText : MonoBehaviour
    {
        public List<StoryText> MoodkillerSlogans = new List<StoryText>(5);
        private StoryText storyText;
        private TextMeshPro storyComponent;
        [SerializeField] private float showTime;

        private void Start()
        {
            GameObject MoodkillerGameObject = GameObject.Find("moodkillersText");
            if (MoodkillerGameObject != null)
            {
                storyComponent = MoodkillerGameObject.GetComponent<TextMeshPro>();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                StoryText storyText = MoodkillerSlogans[Random.Range(1, MoodkillerSlogans.Count)];
                if (storyComponent != null)
                {
                    storyComponent.gameObject.SetActive(true);
                    storyComponent.SetText(storyText.description);
                    StartCoroutine(HideText());
                }
            }
        }

        IEnumerator<WaitForSeconds> HideText()
        {
            yield return new WaitForSeconds(showTime);
            if (storyComponent != null) storyComponent.gameObject.SetActive(false);
        }

    }
}
