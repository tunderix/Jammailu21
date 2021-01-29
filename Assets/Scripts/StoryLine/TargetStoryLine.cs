using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TerraFirma
{
    public class TargetStoryLine : MonoBehaviour
    {
        [SerializeField] private StoryText storyText;
        [SerializeField] private TextMeshPro storyComponent;

        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                storyComponent.gameObject.SetActive(true);
                storyComponent.SetText(storyText.description);
            }
        }

    }
}
