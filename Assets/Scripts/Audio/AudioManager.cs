using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioData;
    public float LowPitchRange = .95f;
    public float HighPitchRange = 1.05f;

    // Play a random clip from an array, and randomize the pitch slightly.
    public void RandomSoundEffect(params AudioClip[] clips)
    {
        int randomIndex = Random.Range(0, clips.Length);
        float randomPitch = Random.Range(LowPitchRange, HighPitchRange);

        audioData.pitch = randomPitch;
        audioData.clip = clips[randomIndex];
        audioData.Play();
    }
}