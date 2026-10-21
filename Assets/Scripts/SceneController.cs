using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public List<CharController> customers = new List<CharController>();
    public Image morning_bg;
    public Image afternoon_bg;
    public Image night_bg;

    private int current_customer = 0;
    private int afternoon_customer;
    private int night_customer;

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

        morning_bg.CrossFadeAlpha(255.0f, 5.0f, false);
        afternoon_bg.CrossFadeAlpha(0.0f, 5.0f, false);
        night_bg.CrossFadeAlpha(0.0f, 5.0f, false);

        int bg_change = Mathf.CeilToInt(customers.Count / 3);

        afternoon_customer = customers.Count - (bg_change * 2);
        night_customer = customers.Count - bg_change;
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

            current_customer += 1;

            // Change the background based on the current customer
            if (current_customer == afternoon_customer)
            {
                morning_bg.CrossFadeAlpha(0.0f, 5.0f, false);
                afternoon_bg.CrossFadeAlpha(255.0f, 5.0f, false);
            }
            if (current_customer == night_customer)
            {
                afternoon_bg.CrossFadeAlpha(0.0f, 5.0f, false);
                night_bg.CrossFadeAlpha(255.0f, 5.0f, false);
            }
        }
        else
        {
            // TODO: Replace with end of day code
            print("End of day");
        }
    }
}
