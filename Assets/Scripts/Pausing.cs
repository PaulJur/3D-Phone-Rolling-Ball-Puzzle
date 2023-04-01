using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausing : MonoBehaviour
{
    public GameObject _pauseMenuUi;
    
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            //if double tap twice, pauses the game and unhides the pause menu
            if (Input.GetTouch(0).tapCount == 2)
            {
                _pauseMenuUi.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
    //Goes back to the menu
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    //Opens the Help menu in-game
    public void Help()
    {

    }
    //Unpauses the game and hides the pausemenu
    public void Resume()
    {
        Time.timeScale = 1f;
        _pauseMenuUi.SetActive(false);
    }
}
