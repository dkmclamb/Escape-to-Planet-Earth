using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLightLv2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ClickControlLv2.totalDigits == 3 && ClickControlLv2.playerCode != ClickControlLv2.correctCode)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            StartCoroutine(waitToUnEnable());
        }
    }

    IEnumerator waitToUnEnable()
    {
        yield return new WaitForSeconds(1);
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
