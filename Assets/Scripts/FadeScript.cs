using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{
    public Animator animation;
    private int levelLoad;

   public void fadeLevel(int levelIndex)
    {
        levelLoad = levelIndex;
        animation.SetTrigger("FadeOut");
    }
    public void fadeComplete()
    {
        SceneManager.LoadScene(levelLoad);
    }


}
