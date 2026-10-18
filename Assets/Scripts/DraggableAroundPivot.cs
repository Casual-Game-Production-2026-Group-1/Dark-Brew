using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.InputSystem;
using static Utilities;
using Unity.Android.Gradle.Manifest;
using Unity.VisualScripting;

public class DraggableAroundPivot : TouchManager
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
    UnityEngine.Quaternion init_rot;
    protected bool grabbed = false;
    int elapsed_time;
    private UnityEngine.Quaternion lerp_rot;
    private UnityEngine.Vector3 lerp_pos;
    private float target_rot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Save object's initital position
        init_rot = this.transform.rotation;
        lerp_pos = this.transform.position;
        lerp_rot = init_rot;
    }

    // Update is called once per frame
    void Update()
    {
        // If the player is grabbing the object
        if (grabbed)
        {
            Ray ray = Camera.main.ScreenPointToRay(touch_point);

            if (Physics.Raycast(ray, out RaycastHit raycastHit))
            {
                UnityEngine.Vector3 rotate_towards = new UnityEngine.Vector3(raycastHit.point.x, this.transform.position.y, raycastHit.point.z);
                this.transform.LookAt(raycastHit.point);
            }

        }
    }

    protected override void TouchPressed(InputAction.CallbackContext context)
    {
        base.TouchPressed(context);
        if (context.canceled)
        {
            elapsed_time = 0;
            grabbed = false;
        }
        // Start following when the player holds the object
        if (context.performed && IsNear(touch_point.x, this.transform.position.x, buffer) && IsNear(touch_point.y, this.transform.position.y, buffer))
        {
            grabbed = true;
        }
    }

    protected virtual void Dropped()
    {
        // NOTE: Overwrite this in extended scripts with drop logic
        return;
    }
}
