using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using static Utilities;

public class Garbage : Appliance
{
    public override void Activate(string input_name, GameObject activator)
    {
        Coffee activating_coffee = activator.GetComponent<Coffee>();
        if (activating_coffee != null)
        {
            activating_coffee.ingredients.Clear();
            print("Trashed coffe");
        }
        base.Activate(input_name, activator);
    }
}
