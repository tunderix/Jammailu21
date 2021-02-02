using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TerraFirma
{
    public class MoodkillersText : MonoBehaviour
    {
        public List<StoryText> MoodkillerSlogans;
        private StoryText storyText;
        private TextMeshPro storyComponent;
        [SerializeField] private float showTime;

        private void Awake()
        {
            storyComponent = GameObject.Find("moodkillersText").gameObject.GetComponent<TextMeshPro>();
            MoodkillerSlogans = new List<StoryText>(10);
        }

        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player != null && MoodkillerSlogans.Count > 0)
            {
                if (storyComponent == null) return;
                StoryText storyText = MoodkillerSlogans[Random.Range(0, MoodkillerSlogans.Count)];
                storyComponent.gameObject.SetActive(true);
                storyComponent.SetText(storyText.description);
                StartCoroutine(HideText());
            }
        }

        IEnumerator<WaitForSeconds> HideText()
        {
            yield return new WaitForSeconds(showTime);
            storyComponent.gameObject.SetActive(false);
        }

    }
}
