using UnityEngine;

public class Grinder : Appliance
{
    bool grinding = false;
    string roast_type;

    public GrinderHandle grinder_handle;
    public Ingredient light_grounds;
    public Ingredient medium_grounds;
    public Ingredient dark_grounds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (grinding)
        {
            if (grinder_handle.grind_time >= 60.0f)
            {
                grinder_handle.can_grind = false;
                grinder_handle.grind_time = 0.0f;

                if (roast_type == "light_roast")
                {
                    Instantiate(light_grounds);
                }
                else if (roast_type == "medium roast")
                {
                    Instantiate(medium_grounds);
                }
                else
                {
                    Instantiate(dark_grounds);
                }

                grinding = false;
            }
        }
    }

    public override void DropActivate(string input_name, GameObject activator)
    {   
        // Get the ingredient dropped onto this (only accepts beans)
        Ingredient activating_ingredient = activator.GetComponent<Ingredient>();
        // Start brewing if ingredient is valid
        if (!grinding && activating_ingredient != null)
        {
            roast_type = input_name;
            grinding = true;
            grinder_handle.can_grind = true;
        }
        
        base.DropActivate(input_name, activator);
    }
}
