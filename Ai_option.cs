using UnityEngine;
using TMPro;

public class AISuggestion : MonoBehaviour
{
    public TMP_InputField themeInput;
    public CarColorChanger carColor;
    public WheelColorChanger wheelColor;

    public void GenerateSuggestion()
    {
        string theme = themeInput.text.ToLower();

        if(theme == "sporty")
        {
            carColor.ChangeToRed();
            wheelColor.ChangeWheelBlack();
        }

        else if(theme == "luxury")
        {
            carColor.ChangeToBlue();
            wheelColor.ChangeWheelWhite();
        }

        else if(theme == "eco")
        {
            carColor.ChangeToBlue();
            wheelColor.ChangeWheelBlack();
        }

        else
        {
            carColor.ChangeToRed();
            wheelColor.ChangeWheelWhite();
        }
    }
}