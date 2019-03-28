using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPassword : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            if (GetComponent<InputField>().text == "password")
            {
                Debug.Log("Correct password!");
            }
            
            else
            {
                Debug.Log("Wrong password! Try again!");
                GetComponent<InputField>().text = "";
            }
        }
    }
}
