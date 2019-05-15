using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableLevel1Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ClickControl.totalDigits == 3 && ClickControl.playerCode == ClickControl.correctCode)
        {
            Button AccessButton = GetComponent<Button>();
            AccessButton.interactable = false;
        }
    }
}
