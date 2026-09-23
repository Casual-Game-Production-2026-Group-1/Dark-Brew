using UnityEngine;

public class SpriteResolutionScalar : MonoBehaviour
{
    private Vector3 init_scale;
    public Vector3 target_scale = new Vector3(827, 407, 1);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        init_scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        print(Screen.width);
        print(Screen.height);
        this.transform.localScale = new Vector3((Screen.width / target_scale.x) * init_scale.x, (Screen.height / target_scale.y) * init_scale.y, 1);
    }
}
