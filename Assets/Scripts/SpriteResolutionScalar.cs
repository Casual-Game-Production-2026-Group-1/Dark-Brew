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
        //print(Screen.width);
        //print(Screen.height);
        this.transform.localScale = new Vector3(target_resolution.x / Screen.width * init_scale.x, target_resolution.y / Screen.height * init_scale.y, 1);
    }
}
