using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Holopanel : MonoBehaviour
{
    public bool isOn;
    public Holopanel[] array;
    private SpriteRenderer spriteR;
    private Sprite yellow;
    private Sprite green;
    private Sprite grey;
    private UnityEngine.Sprite[] sprites;
    private char g = 'G';

    // Start is called before the first frame update
    void Start()
    {
        sprites = Resources.LoadAll<Sprite>("Sprites");
        yellow = sprites[6];
        green = sprites[0];
        grey = sprites[1];
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        isOn = false;
        spriteR.sprite = grey;
    }

    // Update is called once per frame
    void Update()
    {
        if (array[0].isOn == false && array[1].isOn == true && array[2].isOn == false && array[3].isOn == true && array[4].isOn == true && array[5].isOn == false && array[6].isOn == false && array[7].isOn == false && array[8].isOn == true && array[9].isOn == false && array[10].isOn == true && array[11].isOn == false && array[12].isOn == false && array[13].isOn == true && array[14].isOn == true && array[15].isOn == true)
        {
            StartCoroutine(waitToLeaveDockingBay());
        }
    }

    public void Change()
    {
        if (isOn)
        {
            isOn = false;
            spriteR.sprite = grey;
        }
        else
        {
            isOn = true;
            if (gameObject.name[0] == g)
            {
                spriteR.sprite = green;
            }
            else
            {
                spriteR.sprite = yellow;
            }
        }
    }

    IEnumerator waitToLeaveDockingBay()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Escape Scene");
    }
}
