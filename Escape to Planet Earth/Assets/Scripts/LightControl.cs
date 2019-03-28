using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LightControl : MonoBehaviour, IPointerUpHandler
{
    public string id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        id = gameObject.name;
        id = id.Substring(1);
        makeMove(int.Parse(id));
    }

    void makeMove(int name)
    {
        alterCheck(name);
        alterCheck(name + 6);
        alterCheck(name - 6);

        if (name % 6 != 0)
        {
            alterCheck(name + 1);
        }
        if (name % 6 != 1)
        {
            alterCheck(name - 1);
        }
    }

    void alterCheck(int name)
    {
        if (name < 1 || name > 36)
        {
            return;
        }
        GameObject alterObj = GameObject.Find(name.ToString()).gameObject;
        alterObj.GetComponent<LightSwitch>().Change();
    }
}
