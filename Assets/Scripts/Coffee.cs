using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using static Utilities;

public class Coffee : Draggable
{
    public List<string> ingredients = new List<string>();
    public CharController character_controller;
    bool overlapping = false;
    GameObject overlapping_object;
    protected override void Dropped()
    {
        if (overlapping)
        {
            SubmitCoffee();
        }
        print(name + " dropped!");
        base.Dropped();
    }
    private void SubmitCoffee()
    {
        ingredients.Sort();
        if (string.Join(", ", character_controller.order) == string.Join(", ", ingredients))
        {
            print(" - Submitted coffee: Correct order!");
        }
        else
        {
            print(" - Submitted coffee: Wrong order!");
        }
    }

    // Set if coffee is overlapping submit tray
    private void OnTriggerEnter2D(Collider2D other)
    {
        print(name + " overlapping something");
        if (other.gameObject.layer == 7)
        {
            overlapping = true;
            overlapping_object = other.gameObject;
            print(name + " overlapping submit tray");
        }
    }

    // Set if coffee stopped overlapping submit tray
    private void OnTriggerExit2D(Collider2D other)
    {
        print(name + " stopped overlapping something");
        if (other.gameObject.layer == 7)
        {
            overlapping = false;
            overlapping_object = null;
            print(name + " stopped overlapping submit tray");
        }
    }
}
