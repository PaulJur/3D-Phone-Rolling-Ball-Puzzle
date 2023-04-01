using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gairo : MonoBehaviour
{
    Gyroscope _gyroscope;

    // Start is called before the first frame update
    void Start()
    {
        _gyroscope= Input.gyro;
        _gyroscope.enabled = true;
        
    }
    void OnGUI(){
        GUI.Label(new Rect(500, 300, 200, 40), "Gyro rotation rate " + _gyroscope.rotationRate);
        GUI.Label(new Rect(500, 350, 200, 40), "Gyro attitude" + _gyroscope.attitude);
        GUI.Label(new Rect(500, 400, 200, 40), "Gyro enabled : " + _gyroscope.enabled);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
