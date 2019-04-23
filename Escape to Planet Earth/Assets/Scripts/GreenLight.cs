using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            StartCoroutine(waitToLeaveKeypad());
        }
    }

    IEnumerator waitToLeaveKeypad()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Lvl1 Win Dialogue Guard");
    }
    
}
