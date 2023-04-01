using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    [SerializeField]
    private float boost = 5;
    [SerializeField]
    private float X=0, Y=0;
    [SerializeField]
    PlayerController playerMove;
    private void OnTriggerEnter(Collider other)
    {
        //If the player triggers this, the players rigidbody will get a boost to a certain direction by boost(Z(Forward)), X(Right/Left), Y(Up/Down).
        if (other.gameObject.tag == "Player")
        {
            playerMove._rb.AddForce(X, Y, boost, ForceMode.VelocityChange);
        }
    }
    
}
