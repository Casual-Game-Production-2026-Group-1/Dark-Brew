using UnityEngine;
using UnityEngine.InputSystem;
using static Utilities;

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
    private CircleCollider2D col;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Save object's initital position
        init_rot = this.transform.rotation;
        lerp_pos = this.transform.position;
        lerp_rot = init_rot;
        col = this.GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    protected override void Update()
    {
        // If the player is grabbing the object
        if (grabbed)
        {
            this.transform.eulerAngles += new UnityEngine.Vector3(0,0,-0.5f);
        }
        base.Update();
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
        if (context.performed && IsNearVector2(new Vector2(touch_point.x, touch_point.y), new Vector2(col.bounds.center.x, col.bounds.center.y), col.radius / 2.0f))
        {
            grabbed = true;
        }
    }

    protected override void TouchMoved(InputAction.CallbackContext context)
    {
        base.TouchMoved(context);
        if (context.performed && ! IsNearVector2(new Vector2(touch_point.x, touch_point.y), new Vector2(col.bounds.center.x, col.bounds.center.y), col.radius / 2.0f))
        {
            elapsed_time = 0;
            grabbed = false;
        }
    }

    protected virtual void Dropped()
    {
        // NOTE: Overwrite this in extended scripts with drop logic
        return;
    }
}
