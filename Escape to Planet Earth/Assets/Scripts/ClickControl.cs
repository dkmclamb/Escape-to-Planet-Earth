using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickControl : MonoBehaviour
{
    public static string correctCode = "729";
    public static string playerCode = "";
    public static int totalDigits = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerCode);

        if (totalDigits == 3)
        {
            if (playerCode == correctCode)
            {
                //Debug.Log("Correct!");
            }
            else
            {
                playerCode = "";
                totalDigits = 0;
                //Debug.Log("Nope!");
            }
        }
    }

    void OnMouseUp()
    {
        playerCode += gameObject.name;
        totalDigits += 1;
    }
}
