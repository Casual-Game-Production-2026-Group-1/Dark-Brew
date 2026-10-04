using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using static Utilities;

public class Appliance : MonoBehaviour
{
    // List of valid ingredient inputs
    public List<string> ingredients = new List<string>();
    // How close must the player tap to interact
    public float buffer = 1.0f;
    // Set the zdepth
    public float zdepth = 1.0f;

    public virtual void DropActivate(string input_name, GameObject activator)
    {
        // Override this with appliance specific code
        print("  --" + name + " drop activated!");
    }
    public virtual void TapActivate()
    {
        // Override this with appliance specific code
        print("  --" + name + " tap activated!");
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
