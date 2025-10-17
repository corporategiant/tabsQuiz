using UnityEngine;
using TMPro;


public class CursorPlacement : MonoBehaviour
{
    public TMP_InputField inputField;


void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 for left mouse button or touch
        {
            Vector2 localPoint;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                inputField.GetComponent<RectTransform>(),
                Input.mousePosition,
                null, // Use null for Screen Space - Overlay canvas
                out localPoint
            );

            if (inputField.GetComponent<RectTransform>().rect.Contains(localPoint))
            {
                // Click occurred within the InputField
                // Proceed to find the character index
                TMP_TextInfo textInfo = inputField.textComponent.textInfo;
                int closestCharacterIndex = 0;
                float minDistance = float.MaxValue;

                for (int i = 0; i < textInfo.characterCount; i++)

                {
                    TMP_CharacterInfo charInfo = textInfo.characterInfo[i];
                    Vector2 charCenter = (charInfo.topLeft + charInfo.bottomRight) / 2f;

                    // Convert charCenter from textComponent local space to inputField local space if necessary
                    // (Often, they are the same if the textComponent is a child of the inputField and fills it)

                    float distance = Vector2.Distance(localPoint, charCenter);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestCharacterIndex = i;
                    }
                }

                inputField.caretPosition = closestCharacterIndex;
                inputField.ForceLabelUpdate(); // Ensure the caret updates visually
            }
        }
    }
}
