using UnityEngine;

public class WheelColorChanger : MonoBehaviour
{
    public Renderer[] wheelRenderers;

    public void ChangeWheelBlack()
    {
        foreach(Renderer r in wheelRenderers)
        {
            r.material.color = Color.black;
        }
    }

    public void ChangeWheelWhite()
    {
        foreach(Renderer r in wheelRenderers)
        {
            r.material.color = Color.white;
        }
    }
}