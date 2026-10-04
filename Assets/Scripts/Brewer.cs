using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;
using static Utilities;

public class Brewer : Appliance
{
    public Gauge brewer_gauge;
    bool brewing = false;

    // 0: unbrewed, 1: light_brew, 2: medium_brew, 3: dark_brew, 4: overbrewed
    string brew_state = "unbrewed";
    string roast_type;

    public override void DropActivate(string input_name, GameObject activator)
    {
        Ingredient activating_ingredient = activator.GetComponent<Ingredient>();
        if (!brewing && activating_ingredient != null)
        {
            brewer_gauge.SetProgress(100.0f, 1.5f);
            roast_type = input_name;
            brewing = true;
        }
        Coffee activating_coffee = activator.GetComponent<Coffee>();
        if (brewing && activating_coffee != null)
        {
            // Determine brew progress
            float prog_ratio = brewer_gauge.current_progress / brewer_gauge.max_progress;
            if (prog_ratio <= 0.05)
            {
                brew_state = "unbrewed";
            }
            else if (prog_ratio <= 0.3)
            {
                brew_state = "light_brew";
            }
            else if (prog_ratio <= 0.6)
            {
                brew_state = "medium_brew";
            }
            else if (prog_ratio <= 0.9)
            {
                brew_state = "dark_brew";
            }
            else
            {
                brew_state = "overbrewed";
            }

            activating_coffee.ingredients.Add(brew_state);
            activating_coffee.ingredients.Add(roast_type);

            brewer_gauge.SetProgress(0.0f, 9999.0f);

            brewing = false;
        }
        base.DropActivate(input_name, activator);
    }
}
