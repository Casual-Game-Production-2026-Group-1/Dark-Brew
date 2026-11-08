using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public List<CharController> customers = new List<CharController>();
    public Image morning_bg;
    public Image afternoon_bg;
    public Image night_bg;
    public Text patience_counter;
    public Text order_ticket;

    private int current_customer = 0;
    private int afternoon_customer;
    private int night_customer;
    private float customer_patience = 0.0f;
    private bool lose_state = false;
    private float patience_modifier;

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

        FormatTicket();

        //morning_bg.CrossFadeAlpha(255.0f, 5.0f, false);
        //afternoon_bg.CrossFadeAlpha(0.0f, 5.0f, false);
        //night_bg.CrossFadeAlpha(0.0f, 5.0f, false);

        int bg_change = Mathf.CeilToInt(customers.Count / 3);

        afternoon_customer = customers.Count - (bg_change * 2);
        night_customer = customers.Count - bg_change;
    }

    // Update is called once per frames
    void Update()
    {
        if (!lose_state)
        {
            // Customer Patience
            if (customer_patience < customers[0].max_patience)
            {
                if (customers[0].isActiveAndEnabled)
                {
                    patience_modifier = customers[0].attention_modifier;
                }
                else
                {
                    patience_modifier = customers[0].ignore_modifier;
                }

                customer_patience += patience_modifier * Time.deltaTime;
                customer_patience = Mathf.Clamp(customer_patience, 0.0f, customers[0].max_patience);
            }

            if (customer_patience >= customers[0].max_patience && !lose_state)
            {
                lose_state = true;
                // TODO: Replace with fail state code
                print("!! You lost the game! !!");
            }

            // Placeholder text
            patience_counter.text = Mathf.RoundToInt(customer_patience).ToString() + " / " + customers[0].max_patience.ToString();
        }
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

            // Update the patience
            customer_patience = 0.0f;

            // Update ticket
            FormatTicket();

            // Change the background based on the current customer
            if (current_customer == afternoon_customer)
            {
                morning_bg.CrossFadeAlpha(0.0f, 5.0f, false);
                //afternoon_bg.CrossFadeAlpha(255.0f, 5.0f, false);
            }
            if (current_customer == night_customer)
            {
                afternoon_bg.CrossFadeAlpha(0.0f, 5.0f, false);
                //night_bg.CrossFadeAlpha(255.0f, 5.0f, false);
            }
        }
        else
        {
            // TODO: Replace with end of day code
            print("End of day");
        }
    }

    public void FormatTicket()
    {
        order_ticket.text = string.Join(", \n", customers[0].order);
    }
}
