using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteData : MonoBehaviour
{
    public void deletePrefs()
    {
        PlayerPrefs.DeleteAll();
    }

}
