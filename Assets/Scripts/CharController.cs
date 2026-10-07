using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using static Utilities;

public class CharController : MonoBehaviour
{
    public List<string> order = new List<string>();
    void Start()
    {
        order.Sort();
    }
}
