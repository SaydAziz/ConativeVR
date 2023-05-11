using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{

    public GameObject menu;
    public InputActionProperty showButton;

    public void Update()
    {
        //if (Input.anyKey)
        //{
        //    Debug.Log(Input.inputString);
        //}

        if (showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Pause()
    {
        Time.timeScale = 0;

    }

}
