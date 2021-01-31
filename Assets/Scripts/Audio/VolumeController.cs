using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    public class VolumeController : MonoBehaviour
    {
        PlayAudioClip playAudioClip;
        [SerializeField] private AudioSource audioData;

        [Range(0.0f, 1.0f)]
        [SerializeField] private float volumeSlider;

        private string volumeSliderLabel = "MUSIC";
        private GUIContent volumeLabel;
        private void Start()
        {
            playAudioClip = new PlayAudioClip();
            volumeSlider = 0.5f;
            audioData = GetComponent<AudioSource>();
            audioData.Play();
        }

        void OnGUI()
        {
            volumeSlider = GUI.HorizontalSlider(new Rect(25, 25, 200, 60), volumeSlider, 0.0F, 1.0F);
            audioData.volume = volumeSlider;
            GUI.Label(new Rect(30, 5, 200, 60), volumeSliderLabel);
        }
    }
}