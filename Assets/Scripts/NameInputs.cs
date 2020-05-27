using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameInputs : MonoBehaviour {
    public InputField inputField; //place we will type the name
    private string textDisplay; // where we display the output 
    private string levelName = "Home"; //to open the home level

    public void ButtonClick() //The function which we call with OnClick event.
    {
        textDisplay = inputField.text.ToString(); //Where we store the data of InputField object.
        if (inputField.text != "")
        {    
            SceneManager.LoadScene(levelName);
            Debug.Log("Merhaba, " + textDisplay); //Output log of the name user entered if the user typed a name
        }
        else
        {
            Debug.Log("Öğrenci adı girilmedi."); //If no name's been typed.
        }
    }
}
