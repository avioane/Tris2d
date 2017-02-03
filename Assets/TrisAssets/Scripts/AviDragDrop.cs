using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class AviDragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler//, IPointerEnterHandler
{
    public static GameObject itemBeingDragged = null;
    Vector3 startPosition;
    Transform startParent;
    //GameObject objectDragged;

    void Start()
    {
        if(gameObject.tag !=null)
            PlayerPrefs.SetString("clickedPlane", gameObject.tag);
        else
            PlayerPrefs.SetString("clickedPlane", "a1");
        //clickedPlane = gameObject.tag;

        // print("test");
        //PlayerPrefs.SetInt("clickedPlane") = 
        //Debug.Log(PlayerPrefs.GetInt("clickedPlane"));
        /*
        if (PlayerPrefs.GetInt("clickedPlane") == null)
            clickedPlane = PlayerPrefs.GetInt("clickedPlane");
            */
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && itemBeingDragged != null)
            //clickedPlane = find(PlayerPrefs.GetInt("clickedPlane");
            //GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("clickedPlane")).transform.rotation *= Quaternion.Euler(0, 0, -90);
            itemBeingDragged.transform.rotation *= Quaternion.Euler(0, 0, -90);

        //gameObject.transform.rotation *= Quaternion.Euler(0, 0, -90);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("onBeginDrag:" + gameObject.tag);
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        // GetComponent<CanvasGroup>().blocksRaycasts = false;

        if (Input.GetKeyDown("space"))
            gameObject.transform.rotation *= Quaternion.Euler(0, 0, -90);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("onDrag:" + gameObject.tag);
        transform.position = Input.mousePosition;

        if (Input.GetKeyDown("space"))
            itemBeingDragged.transform.rotation *= Quaternion.Euler(0, 0, -90);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("onEndDrag:" + gameObject.tag);
        if (Input.GetKeyDown("space"))
            transform.rotation *= Quaternion.Euler(0, 0, -90);

        //GetComponent<CanvasGroup>().blocksRaycasts = false;
        if (transform.parent != startParent)
        {
            //trying to make it stay in the board1, but not working
            if (Input.mousePosition.x > -318 && Input.mousePosition.x < 0
                && Input.mousePosition.y > 0 && Input.mousePosition.y < 300
                )
                transform.position = startPosition;
            else
                transform.position = startParent.position;

        }
        //itemBeingDragged = null;
    }

    //public void OnPointerEnter(PointerEventData eventData)
    //{
    //    Debug.Log("onPointerEnter:" + gameObject.tag);
    //    if(gameObject.tag=="ChatPanel")
    //        itemBeingDragged = null;
    //    //PlayerPrefs.SetString("clickedPlane", gameObject.tag);
    //}
}
