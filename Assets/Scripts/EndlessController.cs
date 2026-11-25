using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Utilities;

public class EndlessController : SceneController
{
    private int current_customer = 0;
    private int[] customer_order;
    private int loop = 0;
    public float loop_patience_mod = 0.1f;
    private int current_bg = 0;
    private float customer_patience = 0.0f;
    private bool lose_state = false;
    private float patience_modifier;

    void Start()
    {
        RandomizeCustomers();
        // Hide all customers and reveal the selected one
        for (int i = 0; i < customers.Count; i++)
        {
            if (i == current_customer)
            {
                customers[i].gameObject.SetActive(true);
            }
            else
            {
                customers[i].gameObject.SetActive(false);
            }
        }

        FormatTicket();
    }

    // Update is called once per frames
    void Update()
    {
        if (!lose_state)
        {
            // Customer Patience
            if (customer_patience < customers[current_customer].max_patience)
            {
                if (customers[current_customer].isActiveAndEnabled)
                {
                    patience_modifier = customers[current_customer].attention_modifier * 1 - loop_patience_mod * loop;
                }
                else
                {
                    patience_modifier = customers[current_customer].ignore_modifier * 1 + loop_patience_mod * loop;
                }

                customer_patience += patience_modifier * Time.deltaTime;
                customer_patience = Mathf.Clamp(customer_patience, 0.0f, customers[current_customer].max_patience);
            }

            if (customer_patience >= customers[current_customer].max_patience && !lose_state)
            {
                lose_state = true;
                Lose();
            }

            // Placeholder text
            patience_counter.text = Mathf.RoundToInt(customer_patience).ToString() + " / " + customers[current_customer].max_patience.ToString();
        }
    }

    public override void NextCustomer()
    {
        // Disable current customer, then enable the next customer
        customers[current_customer].gameObject.SetActive(false);
        for (int i = 0; i < customer_order.Length; i++)
        {
            if (current_customer == customer_order[i])
            {
                if ((i += 1) < customer_order.Length)
                {
                    current_customer = customer_order[i += 1];
                }
                else
                {
                    RandomizeCustomers();
                    Loop();
                }
            }
        }
        customers[current_customer].gameObject.SetActive(true);

        // Update the patience
        customer_patience = 0.0f;

        // Update ticket
        FormatTicket();

        base.NextCustomer();
    }

    void RandomizeCustomers()
    {
        // Inst customer order array with a set of ints equal to length of customers
        customer_order = new int[customers.Count];
        for (int i = 0; i < customers.Count; i++)
        {
            customer_order[i] = i;
            customers[i].RandomOrder(loop);
        }
        // Shuffle order
        var rng = new System.Random();
        rng.Shuffle(customer_order);

        current_customer = customer_order[0];
    }

    public override int GetCurrentCustomer()
    {
        return current_customer;
    }

    public void FormatTicket()
    {
        order_ticket.text = string.Join(", \n", customers[current_customer].order);
    }

    public void Loop()
    {
        loop += 1;
        // Loop bg
        if (current_bg == 0)
        {
            morning_bg.CrossFadeAlpha(0.0f, 5.0f, false);
            current_bg = 1;
        }
        if (current_bg == 1)
        {
            afternoon_bg.CrossFadeAlpha(0.0f, 5.0f, false);
            current_bg = 2;
        }
        else
        {
            morning_bg.CrossFadeAlpha(255.0f, 4.0f, false);
            afternoon_bg.CrossFadeAlpha(255.0f, 5.0f, false);
            night_bg.CrossFadeAlpha(255.0f, 5.0f, false);
            current_bg = 0;
        }
    }
}
