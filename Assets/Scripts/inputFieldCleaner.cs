using TMPro;
using UnityEngine;

public class InputFieldCleaner : MonoBehaviour
{
    public TMP_InputField[] myInputFields; // Assign your TMP_InputField in the Inspector

    public void RemoveZeroWidthSpaces()
    {
        foreach (TMP_InputField myInputField in myInputFields){
        if (myInputField != null)
        {
            // Get the current text from the input field
            string originalText = myInputField.text;

            // Define the zero-width space character (U+200B)
            char zeroWidthSpace = '\u200B';

            // Replace all occurrences of the zero-width space with an empty string
            string cleanedText = originalText.Replace(zeroWidthSpace.ToString(), "");

            // Update the input field's text with the cleaned version
            myInputField.text = cleanedText;

            Debug.Log("Original Text: " + originalText);
            Debug.Log("Cleaned Text: " + cleanedText);
        
        }
        else
        {
            Debug.LogError("TMP_InputField not assigned!");
        }
        }
    }
}
