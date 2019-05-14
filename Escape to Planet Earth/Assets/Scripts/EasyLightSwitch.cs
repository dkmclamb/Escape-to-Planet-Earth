using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class EasyLightSwitch : MonoBehaviour
{
    public bool isOn;
    public static bool allOn = false;
    private SpriteRenderer spriteR;
    private Sprite lightOn;
    private Sprite lightOff;
    private UnityEngine.Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        sprites = Resources.LoadAll<Sprite>("Sprites");
        lightOn = sprites[4];
        lightOff = sprites[5];
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
        allOn = true;
        EasyLightSwitch[] array = FindObjectsOfType(GetType()) as EasyLightSwitch[];
        foreach (EasyLightSwitch light in array)
        {
            if (light.isOn != true)
            {
                allOn = false;
                break;
            }
        }
        if (allOn)
        {
            StartCoroutine(waitToLeaveLightPuzzle());
        }
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

    IEnumerator waitToLeaveLightPuzzle()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Lvl2 Win Dialogue Guard");
    }

}
