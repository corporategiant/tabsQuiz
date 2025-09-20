using UnityEngine;
using UnityEngine.UI;

public class InputFieldForceUppercase : MonoBehaviour
{

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        GetComponent<InputField>().onValidateInput +=
            delegate (string s, int i, char c) { return char.ToUpper(c); };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
