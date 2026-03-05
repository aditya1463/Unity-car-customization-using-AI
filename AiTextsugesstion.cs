using UnityEngine;
using TMPro;

public class AiSuggestion : MonoBehaviour
{
    public TextMeshProUGUI suggestionText;

    string[] suggestions =
    {
        "AI Suggestion: Try Red color for the car.",
        "AI Suggestion: Blue color looks better.",
        "AI Suggestion: Reset the car to default color."
    };

    public void GenerateSuggestion()
    {
        int index = Random.Range(0, suggestions.Length);
        suggestionText.text = suggestions[index];
    }
}