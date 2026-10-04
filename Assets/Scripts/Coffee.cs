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
    public string ingredient_name = "coffee";
    public CharController character_controller;
    bool overlapping = false;
    GameObject overlapping_object;
    protected override void Dropped()
    {
        if (overlapping)
        {
            // If we're overlapping an appliance and the input is valid, activate it
            Appliance overlapping_appliance = overlapping_object.GetComponent<Appliance>();
            if (overlapping_appliance != null && overlapping_appliance.ingredients.Contains(ingredient_name))
            {
                overlapping_appliance.DropActivate(ingredient_name, this.gameObject);
            }
            // If we're overlapping the submit tray, submit our coffee
            SubmissionTray overlapping_tray = overlapping_object.GetComponent<SubmissionTray>();
            if (overlapping_tray != null)
            {
                SubmitCoffee();
            }
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
        if (other.gameObject.layer == 7)
        {
            overlapping = true;
            overlapping_object = other.gameObject;
            print(name + " overlapping " + other.gameObject.name);
        }
    }

    // Set if coffee stopped overlapping submit tray
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == 7 && overlapping_object == other.gameObject)
        {
            overlapping = false;
            overlapping_object = null;
            print(name + " stopped overlapping " + other.gameObject.name);
        }
    }
}
