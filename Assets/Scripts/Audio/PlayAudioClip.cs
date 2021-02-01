using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma
{
    [RequireComponent(typeof(AudioSource))]
    public class PlayAudioClip : MonoBehaviour
    {
        public AudioClip clip;
        [SerializeField] private AudioSource audioData;

        /*         [Range(0.0f, 1.0f)]
                [SerializeField] private float volumeSlider; */

        private void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                other.gameObject.SetActive(true);
                playClip();
            }
        }
        void playClip()
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
            //volumeSlider = 1.0F;
        }

        /*         void OnGUI()
                {
                    volumeSlider = GUI.HorizontalSlider(new Rect(25, 25, 100, 60), volumeSlider, 0.0F, 1.0F);
                    audioData.volume = volumeSlider;
                } */


    }
}
