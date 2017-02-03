using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class AviDragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged = null;
    Vector3 startPosition;
    Transform startParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
       // GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

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
        itemBeingDragged = null;
    }


}
