using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public List<CharController> customers = new List<CharController>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        return;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextCustomer()
    {
        // Disable current customer, remove them from the list, then enable the next customer
        customers[0].gameObject.SetActive(false);
        customers.RemoveAt(0);
        customers[0].gameObject.SetActive(true);
        print(customers[0].name);
    }
}
