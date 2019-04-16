using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckPassword : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            if (GetComponent<InputField>().text == "Alein")
            {
                StartCoroutine(waitToEnterTerminal());
                //Debug.Log("Correct password!");
            }
            
            else
            {
                Debug.Log("Wrong password! Try again!");
                GetComponent<InputField>().text = "";
            }
        }
    }
    IEnumerator waitToEnterTerminal()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Terminal Cypher");
    }
}
