using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lab1_start : MonoBehaviour
{
    public GameObject IntroImage; //place we will get the image
    //public GameObject PanelDialogue; //panel which allows us not to click on the other objects while pop-up is on

    public void ImageHide() //The function which we call with OnClick event.
    {
        Debug.Log("method calisiyor");
        IntroImage.SetActive(false);
        //PanelDialogue.SetActive(false);
    }
}
