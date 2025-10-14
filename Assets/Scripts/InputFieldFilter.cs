using UnityEngine;
using TMPro;

public class InputFieldFilter : MonoBehaviour
{
    public TMP_InputField[] inputFields;
    public char keyToExclude = '\t'; // The key you want to exclude

    void Start()
    {
        foreach (TMP_InputField inputField in inputFields)
        {
            if (inputField != null)
            {
                inputField.onValidateInput += OnValidateInputCallback;
            }
        }
    }

    char OnValidateInputCallback(string text, int charIndex, char addedChar)
    {
        if (addedChar == keyToExclude)
        {
            return '\0'; // Prevent the character from being added
        }
        return addedChar; // Allow other characters
    }

    void OnDestroy()
    {
        foreach (TMP_InputField inputField in inputFields)
        {
            if (inputField != null)
            {
                inputField.onValidateInput -= OnValidateInputCallback;
            }
        }
    }
}
