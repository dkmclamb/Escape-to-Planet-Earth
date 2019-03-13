using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickControl : MonoBehaviour, IPointerUpHandler
{
    public static string correctCode = "729";
    public static string playerCode = "";
    public static int totalDigits = 0;
    public static int numOfTries = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (totalDigits == 3)
        {
            if (playerCode != correctCode)
            {
                playerCode = "";
                totalDigits = 0;
                numOfTries -= 1;

                if (numOfTries == 0)
                {
                    Debug.Log("Sorry, you didn't get the right code. GAME OVER");
                }
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        playerCode += gameObject.name;
        totalDigits += 1;
    }
}
