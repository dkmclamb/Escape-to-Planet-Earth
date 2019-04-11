using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccessLightsPuzzle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ClickControlLv2.totalDigits == 3 && ClickControlLv2.playerCode == ClickControlLv2.correctCode)
        {
            Button AccessButton = GetComponent<Button>();
            AccessButton.enabled = true;
        }
    }
}
