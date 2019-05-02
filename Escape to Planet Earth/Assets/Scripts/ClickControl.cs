using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickControl : MonoBehaviour, IPointerUpHandler
{
    public static string correctCode = "792";
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
                    numOfTries = 5;
                    SceneManager.LoadScene("Game Over");
                }
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (totalDigits < 3)
        {
            playerCode += gameObject.name;
            totalDigits += 1;
        }
    }

    public void resetPlayerCode()
    {
        playerCode = "";
        totalDigits = 0;
    }
}
