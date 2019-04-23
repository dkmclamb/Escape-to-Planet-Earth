using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckPassword : MonoBehaviour
{
    //public static int numOfTries = 5;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            if (GetComponent<InputField>().text == "Alein")
            {
                //numOfTries = 5;
                StartCoroutine(waitToEnterTerminal());
                //Debug.Log("Correct password!");
            }
            
            else
            {
                //Debug.Log("Wrong password! Try again!");
                //numOfTries -= 1;
                GetComponent<InputField>().text = "";
                /*
                if (numOfTries == 0)
                {
                    numOfTries = 5;
                    SceneManager.LoadScene("Game Over");
                }
                */
            }
        }
    }
    IEnumerator waitToEnterTerminal()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Terminal Cypher");
    }
}
