using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteLevelProgress : MonoBehaviour
{
    void Update()
    {
        //DEV STUFF: Deletes all saved playerPrefs 
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerPrefs.SetInt("levelAt", 0);
        }
    }
}
