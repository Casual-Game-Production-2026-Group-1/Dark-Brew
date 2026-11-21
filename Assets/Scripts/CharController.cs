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

    // How much patience the character has until a fail state
    public float max_patience = 100.0f;
    // How much the patience goes down while looking at the customer (should be negative)
    public float attention_modifier = -1.0f;
    // How much the patience goes up while looking away (should be positive)
    public float ignore_modifier = 2.0f;

    void Start()
    {
        order.Sort();
    }
}
