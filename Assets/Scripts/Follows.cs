using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Utilities;

public class Follows : TouchManager
{
    void Update()
    {
        this.transform.position = touch_point;
    }
}
