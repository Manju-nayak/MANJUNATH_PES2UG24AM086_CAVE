using UnityEngine;

public class FanSwitch : MonoBehaviour
{
    public FanRotate[] fans;

    void OnMouseDown()
    {
        foreach (FanRotate fan in fans)
        {
            fan.fanOn = !fan.fanOn;
        }
    }
}