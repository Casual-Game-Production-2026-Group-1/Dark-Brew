using UnityEngine;
using UnityEngine.InputSystem;
using static Utilities;

public class GrinderHandle : DraggableAroundPivot
{
    public bool can_grind = true;
    public float grind_time = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        if (can_grind)
        {
            grind_time += 1.0f * Time.deltaTime;
            print(" -Grind time: " + grind_time);
        }
        base.Update();
    }

    protected override void TouchPressed(InputAction.CallbackContext context)
    {
        if (can_grind)
        {
            base.TouchPressed(context);
        }
    }

    protected override void TouchMoved(InputAction.CallbackContext context)
    {
        if (can_grind)
        {
            base.TouchMoved(context);
        }
    }
}
