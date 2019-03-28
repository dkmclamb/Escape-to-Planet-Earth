﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LightSwitch : MonoBehaviour
{
    public bool isOn;
    private SpriteRenderer spriteR;
    private Sprite lightOn;
    private Sprite lightOff;
    private UnityEngine.Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        sprites = Resources.LoadAll<Sprite>("Sprites");
        lightOn = sprites[0];
        lightOff = sprites[1];
        isOn = (Random.Range(0, 2) == 0);
        if (isOn == true)
        {
            spriteR = gameObject.GetComponent<SpriteRenderer>();
            spriteR.sprite = lightOn;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change()
    {
        if (isOn)
        {
            isOn = false;
            spriteR = gameObject.GetComponent<SpriteRenderer>();
            spriteR.sprite = lightOff;
        }
        else
        {
            isOn = true;
            spriteR = gameObject.GetComponent<SpriteRenderer>();
            spriteR.sprite = lightOn;
        }
    }

}
