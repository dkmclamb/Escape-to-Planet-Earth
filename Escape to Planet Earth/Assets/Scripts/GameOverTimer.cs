using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitToGoBackToMainMenu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waitToGoBackToMainMenu()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("Main Menu");
    }
}
