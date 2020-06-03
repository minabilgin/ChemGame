using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragEvent : MonoBehaviour, //, IPointerDownHandler, IBeginDragHandler, 
                                        IEndDragHandler, IDragHandler
{
    private Vector3 mOffset;
    private float mouseZCoord;
    //[SerializeField] private Material highlightMaterial;

    /*[SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup; //to catch the dropped obj*/

    /*private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }*/

    private void OnMouseDrag()
    {
        transform.position = GetMousePos() + mOffset;
    }

    private void OnMouseDown()
    {
        mouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        //Store offset = game ojb world pos - mouse pos 
        mOffset = gameObject.transform.position - GetMousePos();
    }

    private Vector3 GetMousePos()
    {
        //pixel cooordinates (x,y)
        Vector3 mousePoint = Input.mousePosition;

        //z coordinate of game obj on screen
        mousePoint.z = mouseZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");

        //This field contains the movement Delta which is the amount that 
        //the mouse moved since the previous frame 
        //Scale factor is to get the mouse position same with canvas scale
        //rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        transform.position = Input.mousePosition;

    }

    //Works when we stop dragging
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        //canvasGroup.alpha = .1f; //to make the obj not transparent after dragging
        //canvasGroup.blocksRaycasts = true; //to make the obj land on the atom machine
        transform.localPosition = Vector3.zero;
    }

    /*private void Update()
    {
        var rayCast = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit; 

        if (Physics.Raycast(rayCast, out hit))
        {
            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            if (selectionRenderer != null)
            {
                selectionRenderer.material = highlightMaterial;
            }
        }

    }*/



    /*[SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup; //to catch the dropped obj

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    //The function to be called when the mouse is pressed:
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    //Works when we begin dragging
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .6f; //to make the obj transparent while dragging
        canvasGroup.blocksRaycasts = false; //to make the obj land on the atom machine
    }

    //Works when we stop dragging
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = .1f; //to make the obj not transparent after dragging
        canvasGroup.blocksRaycasts = true; //to make the obj land on the atom machine

    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");

        //This field contains the movement Delta which is the amount that 
        //the mouse moved since the previous frame 
        //Scale factor is to get the mouse position same with canvas scale
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor; 

    }*/
}
