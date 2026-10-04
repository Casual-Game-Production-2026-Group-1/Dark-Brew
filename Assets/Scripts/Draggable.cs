using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using static Utilities;

public class Draggable : MonoBehaviour
{
    // How close must the player tap to interact
    public float buffer = 1.0f;
    // Set the zdepth while being held
    public float zdepth = 1.0f;
    // Should this object return to its start point when you stop holding
    public bool anchored = false;
    // Should this anchored object interpolate its movement
    public bool interpolate = true;
    public float interp_time = 1.0f;
    // Should this object do something once it's dropped
    public bool droppable = false;
    UnityEngine.Vector3 init_pos;
    UnityEngine.Vector3 init_local_pos;
    protected bool grabbed = false;
    int elapsed_time;
    private UnityEngine.Vector3 lerp_pos;
    private UnityEngine.Vector3 lerp_local_pos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Save object's initital position
        init_pos = this.transform.position;
        init_local_pos = this.transform.localPosition;
        lerp_pos = init_pos;
        lerp_local_pos = init_local_pos;
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
                this.transform.position = new UnityEngine.Vector3(touch_point.x, touch_point.y, init_pos.z);
                grabbed = true;
            }
            // Continue following while the player is holding
            if (touch.phase == TouchPhase.Moved && grabbed)
            {
                this.transform.position = new UnityEngine.Vector3(touch_point.x, touch_point.y, init_pos.z);
            }
            // Stop following when the player stops holding
            if (touch.phase == TouchPhase.Ended)
            {
                if (grabbed)
                {
                    elapsed_time = 0;
                    // If the object is droppable, run the dropped func
                    if (droppable)
                    {
                        Dropped();
                    }
                    // If the object is anchored, return to the initial position
                    if (anchored)
                    {
                        if (interpolate)
                        {
                            lerp_pos = init_pos;
                            lerp_local_pos = init_local_pos;
                        }
                        else
                        {
                            this.transform.position = init_pos;
                            this.transform.localPosition = init_local_pos;
                        }
                    }
                }
                grabbed = false;
            }
        }
        // TODO: Put mouse controls here
        if (!grabbed)
        {
            if (this.transform.position != lerp_pos)
            {
                float interp_ratio = (float)elapsed_time / (interp_time * 60.0f);
                // Interpolate position of the drawer, based on the ratio of elapsed time
                this.transform.position = UnityEngine.Vector3.Lerp(this.transform.position, lerp_pos, interp_ratio);

                elapsed_time += 1;
            }
            if (this.transform.localPosition != lerp_local_pos)
            {
                float interp_ratio = (float)elapsed_time / (interp_time * 0.2f * 60.0f);
                // Interpolate position of the drawer, based on the ratio of elapsed time
                this.transform.localPosition = UnityEngine.Vector3.Lerp(this.transform.localPosition, lerp_local_pos, interp_ratio);

                elapsed_time += 1;
            }
        }
    }

    protected virtual void Dropped()
    {
        // NOTE: Overwrite this in extended scripts with drop logic
        return;
    }
}
