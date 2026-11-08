using System.Collections.Generic;
using UnityEngine;
using static Utilities;

public class SimpleSoundPlayer : MonoBehaviour
{
    public List<AudioClip> sounds = new List<AudioClip>();
    private AudioSource audio_source;

    void Start()
    {
        audio_source = Object.FindAnyObjectByType<AudioSource>();
    }

    public void PlaySound(int index)
    {
        if (audio_source != null && sounds[index] != null)
        {
            PlayOneShotRandomPitch(audio_source, sounds[index]);
        }
    }
}