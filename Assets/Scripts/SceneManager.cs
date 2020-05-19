using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManager;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    //public GameObject door1, door2, door3, door4, door5;

    public void LoadLevel1()
    {
        //To simply load the next level in the queue. 
        //GetActiveScene gets the index of currently loaded level.
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        //Since in my case I will not be loading levels from the main page only:
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene("Level5");
    }

    /*public void QuitGame() {
        Debug.Log("Quit"); //Quit event wont be visible in Unity Editor. 
                           //This is for me to understand that it quits.
        Application.Quit();
    }*/
}