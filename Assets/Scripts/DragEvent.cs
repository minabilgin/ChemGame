using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragEvent : MonoBehaviour
{
    public Transform dropArea;
    public Transform dropAreaSolid;
    public Transform dropAreaLiquid;
    public Transform dropAreaGas;


    public int status;
    

    private Vector3 mOffset;
    private float mouseZCoord;

    private bool isTouch;
    private bool isContacting;
    private Vector3 dropPos;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void OnMouseUp()
    {
        isTouch = false;
        if (isContacting)
        {
            transform.position = dropPos;
            isContacting = false;
            //startPosition = transform.position;
            //transform.position = startPosition;
        }
        else transform.position = startPosition;
        //else startPosition = transform.position;

        /*if (isContacting)
        {
            transform.position = dropAreaSolid.position;
        }
        else transform.position = startPosition;

        if (isContacting)
        {
            transform.position = dropAreaLiquid.position;
        }
        else transform.position = startPosition;

        if (isContacting)
        {
            transform.position = dropAreaGas.position;
        }
        else transform.position = startPosition;*/
    }

    private void OnMouseDown()
    {
        isTouch = true;
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "DropArea")
        {
            isContacting = true;
            dropPos = other.transform.position;
        }
       if (other.name == "DropSolid" /*&& status == 1*/ )
        {
            isContacting = true;
            dropPos = other.transform.position;
        }
        if (other.name == "DropLiquid" /*&& status == 2*/)
        {
            isContacting = true;
            dropPos = other.transform.position;
        }
        if (other.name == "DropGas"/* && status == 3*/)
        {
            isContacting = true;
            dropPos = other.transform.position;
        }


        if (other.CompareTag("Solid") && this.CompareTag("Solid"))
        {
            CheckAnswer.instance.isSolid = true;
            Debug.Log("Solid true");
        }
        if (other.CompareTag("Liquid") && this.CompareTag("Liquid"))
        {
            CheckAnswer.instance.isLiquid = true;
            Debug.Log("Liquid true" );
        }
        if (other.CompareTag("Gas") && this.CompareTag("Gas"))
        {
            CheckAnswer.instance.isGas = true;
            Debug.Log("Gas true" );
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "DropArea"|| other.name == "DropSolid" || other.name == "DropLiquid" || other.name == "DropGas")
        {
            isContacting = false;
        }
        if (other.CompareTag("Solid") && this.CompareTag("Solid"))
        {
            CheckAnswer.instance.isSolid = false;
            Debug.Log("Solid False");
        }
        if (other.CompareTag("Liquid") && this.CompareTag("Liquid"))
        {
            CheckAnswer.instance.isLiquid = false;
            Debug.Log("Liquid False");
        }
        if (other.CompareTag("Gas") && this.CompareTag("Gas"))
        {
            CheckAnswer.instance.isGas = false;
            Debug.Log("GasFalse");
        }
    }

    private Vector3 GetMousePos()
    {
        //pixel cooordinates (x,y)
        Vector3 mousePoint = Input.mousePosition;

        //z coordinate of game obj on screen
        mousePoint.z = mouseZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
  
    private void Update()
    {
        RaycastHit hit;
        Ray rayCast = Camera.main.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(rayCast, out hit) && isTouch)
        {
            Debug.Log("ADSADAD");
            transform.position = new Vector3(hit.point.x, hit.point.y, transform.position.z);
        }
    }
}
