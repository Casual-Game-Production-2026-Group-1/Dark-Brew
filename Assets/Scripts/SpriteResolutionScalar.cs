using UnityEngine;

public class SpriteResolutionScalar : MonoBehaviour
{
    private Vector3 init_scale;
    private Screen saved_resolution;
    public Vector3 target_resolution = new Vector3(1307, 604, 1);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        init_scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        print("Screen width: " + Screen.width);
        print("Screen height: " + Screen.height);

        float triangulate_target = Mathf.Sqrt(Mathf.Pow(target_resolution.x, 2) + Mathf.Pow(target_resolution.y, 2));
        float triangulate_screen = Mathf.Sqrt(Mathf.Pow(Screen.width, 2) + Mathf.Pow(Screen.height, 2));
        float new_scale = triangulate_screen / triangulate_target;

        this.transform.localScale = new Vector3(new_scale, new_scale, target_resolution.z);
    }
}
