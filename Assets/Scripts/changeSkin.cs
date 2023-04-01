using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine.EventSystems;

public class changeSkin : MonoBehaviour
{
    [SerializeField]
    private Button[] button;
    [SerializeField]
    private Material[] Materials = new Material[5];
    private int currentSkin;
    Renderer rend;

    [SerializeField]
    private ParticleSystem[] particleSystem;

    #region skinBool
    private bool fireUnlocked;
    private bool greenUnlocked;
    private bool rubyUnlocked;
    private bool lavaUnlocked;
    #endregion

    private void Start()
    {
        rend = GetComponent<Renderer>();
        currentSkin = PlayerPrefs.GetInt("storedSkins", currentSkin);
        rend.material = Materials[currentSkin];

        checkUnlock();


    }
    private void FixedUpdate()
    {
        int currentSkin = getCurrentSkin();
        Debug.Log(currentSkin);

        foreach(ParticleSystem particleSystem in particleSystem)
        {
            particleSystem.Stop();
        }

        switch (currentSkin)
        {

            case 0:
                particleSystem[0].Play();
                break;

            case 1:
                particleSystem[1].Play();
                break;

            case 2:
                particleSystem[2].Play();
                break;

            case 3:
                particleSystem[3].Play();
                break;

            case 4:
                particleSystem[4].Play();
                break;

            default:
                break;
        }

    }

    #region skinButton
    public void setDefault()
    {
        currentSkin = 0;
        PlayerPrefs.SetInt("storedSkins", currentSkin);
        rend.material = Materials[0];
    }
    public void setFire()
    {
        currentSkin = 1;
        PlayerPrefs.SetInt("storedSkins", currentSkin);
        rend.material = Materials[1];
    }
    public void setMagma()
    {
        currentSkin = 2;
        PlayerPrefs.SetInt("storedSkins", currentSkin);
        rend.material = Materials[2];
    }
    public void setRuby()
    {
        currentSkin = 3;
        PlayerPrefs.SetInt("storedSkins", currentSkin);
        rend.material = Materials[3];
    }
    public void setLava()
    {
        currentSkin = 4;
        PlayerPrefs.SetInt("storedSkins", currentSkin);
        rend.material = Materials[4];
    }
    #endregion

    private void OnTriggerEnter(Collider other)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        #region level1Unlock
        if (currentScene == 1 && other.gameObject.tag == "FinishPoint")
        {
            PlayerPrefs.SetInt("fireUnlocked", 1);
        }   
        else
        {
            PlayerPrefs.GetInt("fireUnlocked", 0);
        }
        #endregion

        #region level2Unlock
        if (currentScene==2 && other.gameObject.tag == "FinishPoint")
        {
            PlayerPrefs.SetInt("greenUnlocked", 1);
        }
        else
        {
            PlayerPrefs.GetInt("greenUnlocked",0);
        }
        #endregion

        #region level3Unlock
        if (currentScene == 3 && other.gameObject.tag == "FinishPoint")
        {
            PlayerPrefs.SetInt("rubyUnlocked", 1);
            Debug.Log("RubyUnlocked");
        }
        else
        {
            PlayerPrefs.SetInt("rubyUnlocked", 0);
        }
        #endregion

        #region level4Unlock
        if (currentScene == 4 && other.gameObject.tag == "FinishPoint")
        {
            PlayerPrefs.SetInt("lavaUnlocked", 1);
        }
        else
        {
            PlayerPrefs.SetInt("lavaUnlocked", 0);
        }
        #endregion
    }
    private void checkUnlock()
    {
        #region fireCheck
        if (PlayerPrefs.GetInt("fireUnlocked")==1)
        {
            button[1].interactable = true;

        }
        else
        {
            button[1].interactable = false;
        }
        #endregion

        #region greenCheck
        if (PlayerPrefs.GetInt("greenUnlocked")==1) 
        {
            button[2].interactable = true;
        }
        else 
        {
            button[2].interactable = false;
        }
        #endregion

        #region rubyCheck
        if (PlayerPrefs.GetInt("rubyUnlocked")== 1)
        {
            button[3].interactable = true;

        }
        else
        {
            button[3].interactable = false;
        }
        #endregion

        #region lavaCheck
        if (PlayerPrefs.GetInt("lavaUnlocked") == 1)
        {
            button[4].interactable = true;

        }
        else
        {
            button[4].interactable = false;
        }
        #endregion
    }
    private int getCurrentSkin()
    {
        if (PlayerPrefs.HasKey("storedSkins"))
        {
            return PlayerPrefs.GetInt("storedSkins",currentSkin);
        }
        else
        {
            return 0;
        }
    }
}
