using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{

    private void OnMouseDown()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    /*public void QuitGame() {
         //Quit event wont be visible in Unity Editor. 
                           //This is for me to understand that it quits.
        Application.Quit();
        Debug.Log("Quit");
    }*/

    /*void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
            Debug.Log("Quit.");
        }
    }*/
}
