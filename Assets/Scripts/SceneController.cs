using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public List<CharController> customers = new List<CharController>();

    void Start()
    {
        // Hide all customers and reveal the first one
        for (int i = 0; i < customers.Count; i++)
        {
            if (i == 0)
            {
                customers[i].gameObject.SetActive(true);
            }
            else
            {
                customers[i].gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frames
    void Update()
    {

    }

    public void NextCustomer()
    {
        // Disable current customer, remove them from the list, then enable the next customer
        // If there's no customers left, you win da game!
        if (customers.Count > 1)
        {
            customers[0].gameObject.SetActive(false);
            customers.RemoveAt(0);
            customers.TrimExcess();
            customers[0].gameObject.SetActive(true);
        }
        else
        {
            // TODO: Replace with end of day code
            print("End of day");
        }
    }
}
