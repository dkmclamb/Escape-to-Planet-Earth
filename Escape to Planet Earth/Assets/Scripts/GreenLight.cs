using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenLight : MonoBehaviour
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
            GetComponent<SpriteRenderer>().enabled = true;
            //StartCoroutine(waitToUnEnable());
        }
    }
/*
    IEnumerator waitToUnEnable()
    {
        yield return new WaitForSeconds(1);
        GetComponent<SpriteRenderer>().enabled = false;
    }
    */
}
