using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public List<CharController> customers = new List<CharController>();
    public List<Drawer> drawers = new List<Drawer>();
    public Image morning_bg;
    public Image afternoon_bg;
    public Image night_bg;
    public Text patience_counter;
    public Text order_ticket;

    public virtual void NextCustomer()
    {
        // Override on a per-controller basis
        print("Next customer");
    }

    public virtual int GetCurrentCustomer()
    {
        // Override on a per-controller basis
        return 0;
    }

    public void Lose()
    {
        // TODO: Replace with fail state code
    }

    // Close all drawers
    public void CloseAll()
    {
        foreach (var d in drawers)
        {
            d.Close();
        }
    }

    // Open all drawers
    public void OpenAll()
    {
        foreach (var d in drawers)
        {
            d.Open();
        }
    }
}
