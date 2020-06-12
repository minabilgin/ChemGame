using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lab1_Answers : MonoBehaviour
{
    public GameObject IntroImage; //place we will get the image
    //public GameObject PanelDialogue; //panel which allows us not to click on the other objects while pop-up is on
    public string levelName = ""; //to open the home level
    //public GameObject TrueAnswer;
    //public GameObject WrongAnswer;


    public void ImageHide() //The function which we call with OnClick event.
    {
        Debug.Log("wrong answer image hide");
        IntroImage.SetActive(false);
        //PanelDialogue.SetActive(false);
    }

    public void TrueAnswer()
    {
        SceneManager.LoadScene(levelName); //When clicked on "go to lab" button, loads 2nd lab scene

    }

    /*public void OnMouseDown()
    {
        SceneManager.LoadScene(levelName);
    }*/

    /*public void WrongAnswer()
    {
        Debug.Log("method calisiyor");
        IntroImage.SetActive(false);
    }*/

}
