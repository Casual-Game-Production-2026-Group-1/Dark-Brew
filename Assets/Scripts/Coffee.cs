using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Utilities;

public class Coffee : Draggable
{
    public List<string> ingredients = new List<string>();
    public string ingredient_name = "coffee";
    public SceneController scene_controller;
    public AudioClip submit_correct_cound;
    public AudioClip submit_incorrect_cound;
    public SpriteRenderer coffee_liquid;
    bool overlapping = false;
    GameObject overlapping_object;

    protected override void Start()
    {
        base.Start();
        Reset();
    }

    protected override void Update()
    {
        base.Update();
        coffee_liquid.sortingOrder = this.GetComponent<SpriteRenderer>().sortingOrder - 1;
    }

    public void AddToCoffee(string ingredient_name)
    {
        ingredients.Add(ingredient_name);
        if (ingredient_name == "light_roast")
        {
            coffee_liquid.color = new Color(0.604f, 0.443f, 0.275f);
        }
        else if (ingredient_name == "medium_roast")
        {
            coffee_liquid.color = new Color(0.653f, 0.243f, 0.216f);
        }
        else if (ingredient_name == "dark_roast")
        {
            coffee_liquid.color = new Color(0.455f, 0.243f, 0.129f);
        }
        else if (ingredient_name == "light_brew")
        {
            coffee_liquid.color = new Color(coffee_liquid.color.r + 0.6f, coffee_liquid.color.g + 0.06f, coffee_liquid.color.b + 0.06f);
        }
        else if (ingredient_name == "medium_brew")
        { }
        else if (ingredient_name == "dark_brew")
        {
            coffee_liquid.color = new Color(coffee_liquid.color.r - 0.06f, coffee_liquid.color.g - 0.06f, coffee_liquid.color.b - 0.06f);
        }
        coffee_liquid.color = new Color(coffee_liquid.color.r, coffee_liquid.color.g, coffee_liquid.color.b, 1.0f);
    }
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
        List<string> customer_order = scene_controller.customers[scene_controller.GetCurrentCustomer()].order;
        customer_order.Sort();
        print(string.Join(", ", customer_order));
        print(string.Join(", ", ingredients));
        if (string.Join(", ", customer_order) == string.Join(", ", ingredients))
        {
            print(" - Submitted coffee: Correct order!");
            if (audio_source != null && submit_correct_cound != null)
            {
                PlayOneShotRandomPitch(audio_source, submit_correct_cound);
            }
            scene_controller.NextCustomer();
        }
        else
        {
            print(" - Submitted coffee: Wrong order!");
            if (audio_source != null && submit_incorrect_cound != null)
            {
                PlayOneShotRandomPitch(audio_source, submit_incorrect_cound);
            }
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        Reset();
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

    public void Reset()
    {
        ingredients.Clear();
        coffee_liquid.color = new Color(coffee_liquid.color.r, coffee_liquid.color.g, coffee_liquid.color.b, 0.0f);
    }
}
