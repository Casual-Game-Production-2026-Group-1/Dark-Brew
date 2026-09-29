using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using static Utilities;

public class Ingredient : Draggable
{
    public string ingredient_name = "[Ingredient name]";
    bool overlapping = false;
    GameObject overlapping_object;
    protected override void Dropped()
    {
        if (overlapping)
        {
            print(overlapping_object.name);
            // If we're overlapping a coffee and the ingredient isn't already added, add it
            Coffee overlapping_coffee = overlapping_object.GetComponent<Coffee>();
            if (overlapping_coffee != null && !overlapping_coffee.ingredients.Contains(ingredient_name))
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
            print(ingredient_name + " overlapping something");
            if (other.gameObject.layer == 3)
            {
                overlapping = true;
                overlapping_object = other.gameObject;
                print(ingredient_name + " overlapping coffee");
            }
        }
    }

    // Set if ingredient stopped overlapping coffee
    private void OnTriggerExit2D(Collider2D other)
    {
        if (grabbed)
        {
            print(ingredient_name + " stopped overlapping something");
            if (other.gameObject.layer == 3)
            {
                overlapping = false;
                overlapping_object = null;
                print(ingredient_name + " stopped overlapping coffee");
            }
        }
    }
}
