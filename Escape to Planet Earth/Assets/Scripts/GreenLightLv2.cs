using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GreenLightLv2 : MonoBehaviour
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
            GetComponent<SpriteRenderer>().enabled = true;
            StartCoroutine(waitToLeaveKeypad());
        }
    }

    IEnumerator waitToLeaveKeypad()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Collect Key");
    }
}
