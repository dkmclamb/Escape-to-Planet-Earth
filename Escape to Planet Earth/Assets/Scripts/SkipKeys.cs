using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipKeys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            SceneManager.LoadScene("Main Menu");
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            SceneManager.LoadScene("Prison Cell");
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            SceneManager.LoadScene("Guard Station");
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            SceneManager.LoadScene("Docking Bay");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene("Lights Out");
        }
    }
}
