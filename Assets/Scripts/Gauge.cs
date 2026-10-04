using Unity.VisualScripting;
using UnityEngine;

public class Gauge : MonoBehaviour
{
    [SerializeField]
    private GameObject needle;

    private float current_progress = 0.0f;
    private float target_progress = 0.0f;
    private float needle_speed = 100.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void SetProgress(float amt)
    {
        target_progress = amt;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
