using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorMenu : MonoBehaviour
{
   //Setup for menu level selector when a certain button is pressed one of these scenes are called.
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void Level5()
    {
        SceneManager.LoadScene("Level 5");
    }
    public void Level6()
    {
        SceneManager.LoadScene("Level 6");
    }

}
