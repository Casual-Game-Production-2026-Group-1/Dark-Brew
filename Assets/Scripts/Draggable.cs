using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using UnityEngine;
using static Utilities;

public class Draggable : MonoBehaviour
{
    // How close must the player tap to interact
    public float buffer = 1.0f;
    // Set the zdepth while being held
    public float zdepth = 1.0f;
    // Should this object return to its start point when you stop holding
    public bool anchored = false;
    UnityEngine.Vector3 init_pos;
    bool grabbed = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Save object's initital position
        init_pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // If the player is touching the screen
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            // Convert the touch point to world coordinates
            UnityEngine.Vector3 touch_point = Camera.main.ScreenToWorldPoint(new UnityEngine.Vector3(touch.position.x, touch.position.y, zdepth));

            // Start following when the player holds the object
            if (touch.phase == TouchPhase.Began && IsNear(touch_point.x, this.transform.position.x, buffer) && IsNear(touch_point.y, this.transform.position.y, buffer))
            {
                this.transform.position = touch_point;
                grabbed = true;
            }
            // Continue following while the player is holding
            if (touch.phase == TouchPhase.Moved && grabbed)
            {
                this.transform.position = touch_point;
            }
            // Stop following when the player stops holding
            if (touch.phase == TouchPhase.Ended)
            {
                grabbed = false;
                // If the object is anchored, return to the initial position
                if (anchored)
                {
                    this.transform.position = init_pos;
                }
            }
        }
        // TODO: Put mouse controls here
    }
}
