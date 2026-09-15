using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Utilities;

public class Draggable : MonoBehaviour
{
    public float buffer = 1.0f;
    public float zdepth = 1.0f;
    bool grabbed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touch_point = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, zdepth));

            if (touch.phase == TouchPhase.Began && IsNear(touch_point.x, this.transform.position.x, buffer) && IsNear(touch_point.y, this.transform.position.y, buffer))
            {
                this.transform.position = touch_point;
                grabbed = true;
            }
            if (touch.phase == TouchPhase.Moved && grabbed)
            {
                this.transform.position = touch_point;
            }
            if (touch.phase == TouchPhase.Ended)
            {
                grabbed = false;
            }
        }
    }
}
