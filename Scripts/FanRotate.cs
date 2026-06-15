using UnityEngine;

public class FanRotate : MonoBehaviour
{
    public float speed = 800f;
    public bool fanOn = true;

    void Update()
    {
        if (fanOn)
        {
            transform.Rotate(0f, 0f, speed * Time.deltaTime, Space.Self);
        }
    }
}