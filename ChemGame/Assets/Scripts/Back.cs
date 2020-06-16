using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GameObject.FindObjectOfType<Canvas>().transform.GetChild(0).gameObject.activeInHierarchy) return;
        SceneManager.LoadScene(1); //When clicked on back button, loads home scene
    }
}
