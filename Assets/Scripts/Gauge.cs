using UnityEngine;

public class Gauge : MonoBehaviour
{
    [SerializeField]
    private GameObject needle;

    public float needle_speed = 1.0f;
    public float max_progress = 100.0f;

    public float current_progress = 0.0f;
    public float target_progress = 0.0f;


    // Update is called once per frame
    void Update()
    {
        if (target_progress != current_progress)
        {
            UpdateProgress();
        }
    }

    public void SetProgress(float amt, float spd = 1.0f)
    {
        target_progress = amt;
        needle_speed = spd;
    }

    void UpdateProgress()
    {
        if (target_progress > current_progress)
        {
            current_progress += Time.deltaTime * needle_speed;
            current_progress = Mathf.Clamp(current_progress, 0.0f, target_progress);
        }
        else if (target_progress < current_progress)
        {
            current_progress -= Time.deltaTime * needle_speed;
            current_progress = Mathf.Clamp(current_progress, target_progress, max_progress);
        }

        SetNeedle();
    }

    void SetNeedle()
    {
        needle.transform.localEulerAngles = new Vector3(0, 0, (current_progress / max_progress * 360.0f) * -1.0f);
    }
}
