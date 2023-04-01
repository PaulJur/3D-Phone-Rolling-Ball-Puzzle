using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    //Button array to allow as many levels as you want.
    public Button[] buttons;
    [SerializeField]
    private bool Developer = false;
    public int levelAt;
    
    void Start()
    {
        //Sets the current default value to 0
        levelAt = PlayerPrefs.GetInt("levelAt", 1);

           
        for (int i = 0; i < buttons.Length; i++)
        {
            //Checks the current completed levels, for example if Level 1 is completed then level 2 is unlocked.
            if (i + 1 > levelAt)
            {
                buttons[i].interactable = false;
                
            }
            if (Developer == true)
            {
                buttons[i].interactable = true;
             }

        }
        

    }

    
}
