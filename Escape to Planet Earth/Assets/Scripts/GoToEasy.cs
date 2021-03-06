﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToEasy : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    IEnumerator waitToLeaveScene()
    {
        yield return new WaitForSeconds(300);
        SceneManager.LoadScene(sceneName);
    }
}
