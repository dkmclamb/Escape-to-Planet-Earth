using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class HoloPanelController : MonoBehaviour
{
    public Holopanel[] array;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (array[0].isOn == false && array[1].isOn == true && array[2].isOn == false && array[3].isOn == true && array[4].isOn == true && array[5].isOn == false && array[6].isOn == false && array[7].isOn == false && array[8].isOn == true && array[9].isOn == false && array[10].isOn == true && array[11].isOn == false && array[12].isOn == false && array[13].isOn == true && array[14].isOn == true && array[15].isOn == true)
        {
            StartCoroutine(waitToLeaveDockingBay());
        }
    }
    IEnumerator waitToLeaveDockingBay()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Lvl3 Win Dialogue Guard");
    }
}
