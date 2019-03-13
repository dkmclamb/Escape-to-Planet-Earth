using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class MoveLetter : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    public string letterStatus = "";
    /*
    public string GetLetterStatus()
    { return letterStatus; }

    public void SetLetterStatus(string value)
    {
        letterStatus = value;
    }
    */

    // Update is called once per frame
    void Update()
    {
        /*
        if (letterStatus == "pickedUp")//GetLetterStatus() if set back to private
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }

        if (Input.GetMouseButtonDown(0))
        {
            //SetLetterStatus("pickedUp");
            letterStatus = "pickedUp";
        }

        if (Input.GetMouseButtonDown(1))
        {
            //SetLetterStatus("setDown");
            letterStatus = "setDown";
        }
        */
        if (letterStatus == "locked")
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        }

    }

    void OnMouseDown()
    {
        if (letterStatus != "locked")
        {
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }

    void OnMouseDrag()
    {
        if (letterStatus != "locked")
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }
    /*
    void GetMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //SetLetterStatus("pickedUp");
            letterStatus = "pickedUp";
        }

        if (Input.GetMouseButtonDown(1))
        {
            //SetLetterStatus("setDown");
            letterStatus = "setDown";
        }
    }
    */
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == gameObject.name)
        {
            transform.position = other.gameObject.transform.position;
            letterStatus = "locked";
        }
    }
}
