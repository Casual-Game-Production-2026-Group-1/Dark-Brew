using NUnit.Framework.Constraints;
using UnityEngine;
using static Utilities;

public class Drawer : MonoBehaviour
{
    public float interp_time = 1.0f;
    int elapsed_time;
    public Vector3 target_pos;
    private Vector3 init_pos;
    private Vector3 lerp_pos;
    private bool open = false;
    protected AudioSource audio_source;
    public AudioClip open_sound;
    public AudioClip close_sound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        init_pos = this.transform.localPosition;
        lerp_pos = init_pos;
        audio_source = Object.FindAnyObjectByType<AudioSource>();
    }

    void Update()
    {
        if (this.transform.position != lerp_pos)
        {
            float interp_ratio = (float)elapsed_time / (interp_time * 60.0f);
            // Interpolate position of the drawer, based on the ratio of elapsed time
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, lerp_pos, interp_ratio);

            elapsed_time += 1;
        }
    }

    public void Toggle()
    {
        // If open, close the drawer
        if (open)
        {
            Close();
        }
        // Open the drawer
        else
        {
            Open();
        }
    }

    public void Open()
    {
        if (!open)
        {
            elapsed_time = 0;
            lerp_pos = target_pos;

            if (audio_source != null && open_sound != null)
            {
                PlayOneShotRandomPitch(audio_source, open_sound, 0.3f);
            }

            open = true;
        }
    }

    public void Close()
    {
        if (open)
        {
            elapsed_time = 0;
            lerp_pos = init_pos;

            if (audio_source != null && close_sound != null)
            {
                PlayOneShotRandomPitch(audio_source, close_sound);
            }

            open = false;
        }
    }
}
