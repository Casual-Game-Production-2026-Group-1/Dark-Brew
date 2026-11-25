using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using Ink.Parsed;
using UnityEngine;
using UnityEngine.Rendering;
using static Utilities;

public class CharController : MonoBehaviour
{
    public List<string> order = new List<string>();

    // How much patience the character has until a fail state
    public float max_patience = 100.0f;
    // How much the patience goes down while looking at the customer (should be negative)
    public float attention_modifier = -1.0f;
    // How much the patience goes up while looking away (should be positive)
    public float ignore_modifier = 2.0f;

    void Start()
    {
        //order.Sort();
    }

    public void RandomOrder(int mod = 0)
    {
        order = new List<string>();
        var rng = new System.Random();
        // Pick a random roast
        string[] roasts = { "light_roast", "medium_roast", "dark_roast" };
        rng.Shuffle(roasts);
        order.Add(roasts[0]);
        // Pick a random brew
        string[] brews = { "light_brew", "medium_brew", "dark_brew" };
        rng.Shuffle(brews);
        order.Add(brews[0]);
        // Pick random optionals
        string[] other = { "ice", "animal_milk", "nut_milk", "cinnamon", "nutmeg", "salt", "sugar", "caramel", "chocolate", "espresso_shot" };
        rng.Shuffle(other);
        // Logorithmic chance to add an ingredient (higher mod is higher chance)
        float perc = 1 - (1 / (1 + 0.2f * (mod + 1)));
        for (int i = 0; i < other.Length; i++)
        {
            float chance = UnityEngine.Random.Range(0.00f, 1.00f);
            if (perc >= chance)
            {
                order.Add(other[i]);
            }
        }
    }
}
