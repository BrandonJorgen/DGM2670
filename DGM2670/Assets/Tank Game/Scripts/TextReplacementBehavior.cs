using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextReplacementBehavior : MonoBehaviour
{
    private TextMeshProUGUI textToReplace;

    private void Start()
    {
        textToReplace = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateTextWithFloatData(FloatData data)
    {
        textToReplace.text = data.value.ToString();
    }
}