using UnityEngine;

public class EnableOnStart : MonoBehaviour
{
    public bool enabled = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (enabled)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}
