using UnityEngine;

public class WallSwitch : MonoBehaviour
{
    public Light hallLight;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        hallLight.enabled = !hallLight.enabled;

        if (hallLight.enabled)
            rend.material.color = Color.green;
        else
            rend.material.color = Color.red;
    }
}