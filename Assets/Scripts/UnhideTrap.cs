using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnhideTrap : MonoBehaviour
{
    
    [SerializeField]
    private GameObject trap;

    private void OnCollisionEnter(Collision collision)
    {
        //If the player triggers this it will unhide the trap in level 3 and start the chase
        if (collision.gameObject.tag == "Player")
        {
            trap.SetActive(true);
    
        }
    }
}
