using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelControl : MonoBehaviour, IPointerUpHandler
{
    public string id;
    // Start is called before the first frame update
    void Start()
    {
        id = gameObject.name;
        id = id.Substring(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        GameObject alterObj = GameObject.Find(id).gameObject;
        alterObj.GetComponent<Holopanel>().Change();
    }
}
