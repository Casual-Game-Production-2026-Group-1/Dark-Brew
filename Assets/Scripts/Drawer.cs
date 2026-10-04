using Unity.VisualScripting;
using UnityEngine;

public class Drawer : MonoBehaviour
{
    public float interp_time = 1.0f;
    int elapsed_time;
    public Vector3 target_pos;
    private Vector3 init_pos;
    private Vector3 lerp_pos;
    private bool open = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        init_pos = this.transform.localPosition;
        lerp_pos = init_pos;
    }

    void Update()
    {
        if (this.transform.position != lerp_pos)
        {
            float interp_ratio = (float)elapsed_time / (interp_time * 60.0f);
            // Interpolate position of the drawer, based on the ratio of elapsed time
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, lerp_pos, interp_ratio);

            elapsed_time += 1;
        }
    }

    public void Open()
    {
        if (open)
        {
            elapsed_time = 0;
            lerp_pos = init_pos;
            open = false;
        }
        else
        {
            elapsed_time = 0;
            lerp_pos = target_pos;
            open = true;
        }
    }
}
