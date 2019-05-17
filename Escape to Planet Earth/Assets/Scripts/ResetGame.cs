using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ClickControl.playerCode = "";
        ClickControl.totalDigits = 0;
        ClickControl.numOfTries = 5;
        ClickControlLv2.playerCode = "";
        ClickControlLv2.totalDigits = 0;
        ClickControlLv2.numOfTries = 5;
        CheckPassword.numOfTries = 5;
        DontDestroyOnLoadManager.DestroyAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
