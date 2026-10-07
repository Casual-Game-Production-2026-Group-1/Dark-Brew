using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.InputSystem;
using static Utilities;

public class SpriteButton : TouchManager
{
    [Serializable]
    public class ButtonClickedEvent : UnityEvent
    {
    }

    [FormerlySerializedAs("onClick")]
    [SerializeField]
    private ButtonClickedEvent m_OnClick = new ButtonClickedEvent();

    public ButtonClickedEvent onClick
    {
        get
        {
            return m_OnClick;
        }
        set
        {
            m_OnClick = value;
        }
    }
    // How close must the player tap to interact
    public float buffer = 1.0f;
    // Set the zdepth while being held
    public float zdepth = 1.0f;

    protected override void TouchPressed(InputAction.CallbackContext context)
    {
        base.TouchPressed(context);
        if (context.performed && IsNear(touch_point.x, this.transform.position.x, buffer) && IsNear(touch_point.y, this.transform.position.y, buffer))
        {
            UISystemProfilerApi.AddMarker("Button.onClick", this);
            m_OnClick.Invoke();
        }
    }
}
