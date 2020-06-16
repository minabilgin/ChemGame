using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonClick : MonoBehaviour
{
    public static ButtonClick instance;
    public bool ButtonOn = false;
    public Button MyButton;
    public Button OtherButton;
    public bool isTrue = false;

    private void Awake()
    {
        instance = this;
    }
    public void BeenClicked()
    {
        ButtonOn = !ButtonOn;

        OtherButton.interactable = ButtonOn;
        if (!ButtonOn)
        {
            MyButton.image.color = Color.cyan;
            if (MyButton.tag == "T")
            {
                isTrue = true;
                
            }
            else
            {
                isTrue = false;

            }
        }
        else
        {
            MyButton.image.color = Color.white;
            isTrue = false;

        }
    }
}
