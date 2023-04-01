using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    [SerializeField]
    private float boost = 5;
    [SerializeField] PlayerController playerMove;
    private void OnTriggerEnter(Collider other)
    {
        //If the player triggers this, the players rigidbody will get a boost to the Y(Up/Down) axis
        if (other.gameObject.tag == "Player")
        {
            playerMove._rb.AddForce(0, boost, 0, ForceMode.VelocityChange);
        }
    }
}
