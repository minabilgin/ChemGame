using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenImage : MonoBehaviour
{
    public Transform dropArea;
    private float mouseZCoord;

    private bool isTouch;
    private bool isContacting;
    private Vector3 startPosition;

    public List<Sprite> spriteLists = new List<Sprite>();
    public SpriteRenderer monitorSprite;

    private void Start()
    {
        startPosition = transform.position;
    }
    private void OnMouseUp()
    {
        isTouch = false;
        if (isContacting)
        {
            transform.position = dropArea.position;
            monitorSprite.sprite = spriteLists[0];
        }
        else transform.position = startPosition;
    }

    private void OnMouseDown()
    {
        isTouch = true;

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "DropArea")
        {
            isContacting = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "DropArea")
        {
            isContacting = false;
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
            transform.position = new Vector3(hit.point.x, hit.point.y, transform.position.z);
        }

    }
}
