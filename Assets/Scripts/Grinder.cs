using UnityEngine;

public class Grinder : Appliance
{
    bool grinding = false;
    string roast_type;

    public Ingredient light_grounds;
    public Ingredient medium_grounds;
    public ingredient dark_grounds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (grinding)
        {
            
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
        }
        
        base.DropActivate(input_name, activator);
    }
}
