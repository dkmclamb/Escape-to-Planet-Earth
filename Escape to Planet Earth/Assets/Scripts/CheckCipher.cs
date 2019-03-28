using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCipher : MonoBehaviour
{
    private string currentLetters = "";

    // Update is called once per frame
    void Update()
    {
        for (int n = 0; n < gameObject.transform.childCount; n++)
        {
            currentLetters += gameObject.transform.GetChild(n).GetComponent<InputField>().text;
        }
        
        if (currentLetters == "Cipher")
        {
            Debug.Log("Correct cipher!");
        }
        
        currentLetters = "";
    }
}
