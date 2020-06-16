using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level2TF : MonoBehaviour
{
    public static Level2TF instance;

    public GameObject truePanel;
    public GameObject falsePanel;
    public ButtonClick button1, button2, button3, button4, button5, button6;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {

    }
    public void CheckAnswers()
    {
        int correctCounter = 0;

        if (button1.isTrue && button1.gameObject.tag == "T" && !button1.ButtonOn)
        {
            correctCounter++;
        }
        if (button2.isTrue && button2.gameObject.tag == "T" && !button2.ButtonOn)
        {
            correctCounter++;
        }
        if (button3.isTrue && button3.gameObject.tag == "T" && !button3.ButtonOn)
        {
            correctCounter++;
        }
        if (button4.isTrue && button4.gameObject.tag == "T" && !button4.ButtonOn)
        {
            correctCounter++;
        }
        if (button5.isTrue && button5.gameObject.tag == "T" && !button5.ButtonOn)
        {
            correctCounter++;
        }
        if (button6.isTrue && button6.gameObject.tag == "T" && !button6.ButtonOn)
        {
            correctCounter++;
        }

        if (correctCounter == 3)
        {
            truePanel.SetActive(true);
        }
        else
        {
            falsePanel.SetActive(true);
        }

        correctCounter = 0;
    }

 
}