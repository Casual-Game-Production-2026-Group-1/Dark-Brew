using UnityEngine;
using UnityEngine.InputSystem;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

public class TouchManager : MonoBehaviour
{
    // Input Actions
    protected PlayerInput playerInput;
    protected InputAction touchPosAction;
    protected InputAction touchPressAction;

    // Touch vars
    protected Vector3 touch_point;


    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        touchPosAction = playerInput.actions["TouchPosition"];
        touchPressAction = playerInput.actions["TouchPress"];
    }

    private void OnEnable()
    {
        touchPressAction.performed += TouchPressed;
        touchPressAction.canceled += TouchPressed;
        touchPosAction.performed += TouchMoved;
        touchPosAction.canceled += TouchMoved;
    }

    private void OnDisable()
    {
        touchPressAction.performed -= TouchPressed;
        touchPressAction.canceled -= TouchPressed;
        touchPosAction.performed -= TouchMoved;
        touchPosAction.canceled -= TouchMoved;
    }

    protected virtual void TouchPressed(InputAction.CallbackContext context)
    {
        touch_point = Camera.main.ScreenToWorldPoint(touchPosAction.ReadValue<Vector2>());
        touch_point.z = 0.0f;
    }
    protected virtual void TouchMoved(InputAction.CallbackContext context)
    {
        touch_point = Camera.main.ScreenToWorldPoint(touchPosAction.ReadValue<Vector2>());
        touch_point.z = 0.0f;
    }
}
