using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using static Utilities;

public class Ingredient : Draggable
{
    public string ingredient_name = "[Ingredient name]";
    public bool addable_to_coffee = true;
    bool overlapping = false;
    GameObject overlapping_object;
    protected override void Dropped()
    {
        if (overlapping)
        {
            print(overlapping_object.name);
            // If we're overlapping an appliance and the ingredient is valid, activate it
            Appliance overlapping_appliance = overlapping_object.GetComponent<Appliance>();
            if (overlapping_appliance != null && overlapping_appliance.ingredients.Contains(ingredient_name))
            {
                overlapping_appliance.DropActivate(ingredient_name, this.gameObject);
            }
            // If we're overlapping a coffee and the ingredient isn't already added, add it
            Coffee overlapping_coffee = overlapping_object.GetComponent<Coffee>();
            if (addable_to_coffee && overlapping_coffee != null && !overlapping_coffee.ingredients.Contains(ingredient_name))
            {
                overlapping_coffee.ingredients.Add(ingredient_name);
            }
        }
        print(ingredient_name + " dropped!");
        base.Dropped();
    }

    // Set if ingredient is overlapping coffee
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (grabbed)
        {
            if (other.gameObject.layer == 3 || other.gameObject.layer == 7)
            {
                overlapping = true;
                overlapping_object = other.gameObject;
                print(ingredient_name + " overlapping " + other.gameObject.name);
            }
        }
    }

    // Set if ingredient stopped overlapping coffee
    private void OnTriggerExit2D(Collider2D other)
    {
        if (grabbed)
        {
            if ((other.gameObject.layer == 3 || other.gameObject.layer == 7) && overlapping_object == other.gameObject)
            {
                overlapping = false;
                overlapping_object = null;
                print(ingredient_name + " stopped overlapping " + other.gameObject.name);
            }
        }
    }
}
