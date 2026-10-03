using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using static Utilities;

public class Appliance : MonoBehaviour
{
    // List of valid ingredient inputs
    public List<string> ingredients = new List<string>();
    public virtual void Activate(string input_name, GameObject activator)
    {
        // Override this with appliance specific code
        print("  --" + name + " activated!");
    }
}
