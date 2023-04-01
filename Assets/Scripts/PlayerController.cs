using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private bool _isFlip=true;
    [HideInInspector]
    public Rigidbody _rb;
    [SerializeField]
    private float maxSpeed = 10f;
   // public AudioSource _audioSource;
  
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
      //  _audioSource = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        //Player is accelerated by the tilt of the phone
        Vector3 tilt = Input.acceleration;
        if (_isFlip){
        tilt = Quaternion.Euler(140,0,0)*tilt;
              }


      _rb.AddForce(tilt);
        //Sets the max possible speed for the player which is great for certain levels.
        if (_rb.velocity.magnitude > maxSpeed)
        {
            _rb.velocity = _rb.velocity.normalized * maxSpeed;
        }
       // if (_rb.velocity.x >=0.1)
       // {
        //    _audioSource.Play();
        //}

        
    }

}
    


