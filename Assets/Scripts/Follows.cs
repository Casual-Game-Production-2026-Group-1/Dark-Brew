using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Utilities;

public class Follows : MonoBehaviour
{
    public float zdepth = 1.0f;
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

            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved)
            {
                this.transform.position = touch_point;
            }
        }
    }
}
