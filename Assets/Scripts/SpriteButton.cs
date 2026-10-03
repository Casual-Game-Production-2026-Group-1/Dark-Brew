using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using static Utilities;

public class SpriteButton : MonoBehaviour
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
                UISystemProfilerApi.AddMarker("Button.onClick", this);
                m_OnClick.Invoke();
            }
        }
        // TODO: Put mouse controls here
    }
}
