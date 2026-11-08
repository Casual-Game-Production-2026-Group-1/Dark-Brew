using System.Collections.Generic;
using UnityEngine;
using static Utilities;

public class Appliance : MonoBehaviour
{
    // List of valid ingredient inputs
    public List<string> ingredients = new List<string>();
    // How close must the player tap to interact
    public float buffer = 1.0f;
    // Set the zdepth
    public float zdepth = 1.0f;
    private AudioSource audio_source;
    public AudioClip drop_activate_sound;
    public AudioClip tap_activate_sound;

    void Start()
    {
        audio_source = Object.FindAnyObjectByType<AudioSource>();
    }

    public virtual void DropActivate(string input_name, GameObject activator)
    {
        // Override this with appliance specific code
        print("  --" + name + " drop activated!");
        if (audio_source != null && drop_activate_sound != null)
        {
            PlayOneShotRandomPitch(audio_source, drop_activate_sound);
        }
    }
    public virtual void TapActivate()
    {
        // Override this with appliance specific code
        print("  --" + name + " tap activated!");
        if (audio_source != null && tap_activate_sound != null)
        {
            PlayOneShotRandomPitch(audio_source, tap_activate_sound);
        }
    }

    void Update()
    {
        // If the player is touching the screen
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            // Convert the touch point to world coordinates
            UnityEngine.Vector3 touch_point = Camera.main.ScreenToWorldPoint(new UnityEngine.Vector3(touch.position.x, touch.position.y, zdepth));

            // Activate when tapped
            if (touch.phase == TouchPhase.Began && IsNear(touch_point.x, this.transform.position.x, buffer) && IsNear(touch_point.y, this.transform.position.y, buffer))
            {
                TapActivate();
            }
        }
        // TODO: Put mouse controls here
    }
}
