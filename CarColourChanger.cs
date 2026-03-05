using UnityEngine;

public class CarColorChanger : MonoBehaviour
{
    public Renderer[] carParts;   // Drag all 9 parts here in Inspector

    public void ChangeToRed()
    {
        ChangeColor(Color.red);
    }

    public void ChangeToBlue()
    {
        ChangeColor(Color.blue);
    }

    void ChangeColor(Color newColor)
    {
        foreach (Renderer part in carParts)
        {
            part.material.color = newColor;
        }
    }
}