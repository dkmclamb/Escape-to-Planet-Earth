using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueToNextScene : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitToLeaveScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waitToLeaveScene()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(sceneName);
    }
}
