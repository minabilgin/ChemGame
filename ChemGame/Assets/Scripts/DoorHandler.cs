using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class DoorHandler : MonoBehaviour
{
    [Header("CONST")]
    public string levelName = "";
    public float speed = 5f;

    [Header("OBJECTS")]
    public Transform animPivotTrans;
    public Transform animPivotTransForGate5;


    private bool isOpen;

    private void OnMouseOver()
    {
        isOpen = true;
    }
    private void OnMouseExit()
    {
        isOpen = false;
    }
    private void OnMouseDown()
    {
        SceneManager.LoadScene(levelName);
    }
    private void Update()
    {
        if (isOpen)
        {
            animPivotTrans.localRotation = Quaternion.Lerp(animPivotTrans.localRotation, Quaternion.Euler(new Vector3(0, 25f, 0)), speed * Time.deltaTime);
            if (animPivotTransForGate5 != null)
            {
                animPivotTransForGate5.localRotation = Quaternion.Lerp(animPivotTransForGate5.localRotation, Quaternion.Euler(new Vector3(0, -25f, 0)), speed * Time.deltaTime);
            }
        }
        else
        {
            animPivotTrans.localRotation = Quaternion.Lerp(animPivotTrans.localRotation, Quaternion.Euler(Vector3.zero), speed * Time.deltaTime);
            if (animPivotTransForGate5 != null)
            {
                animPivotTransForGate5.localRotation = Quaternion.Lerp(animPivotTransForGate5.localRotation, Quaternion.Euler(Vector3.zero), speed * Time.deltaTime);
            }
        }
    }


}
