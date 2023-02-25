using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    public float speed;
    float newSpeed = RotatorSpeed.RotateSpeed;
   
    void Update()
    {
        transform.Rotate(0f, 0f, speed * newSpeed * Time.deltaTime);
    }

        
    
}
