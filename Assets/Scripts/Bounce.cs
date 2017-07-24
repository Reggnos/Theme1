using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    Vector3 rotationAngle;



    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Wall")
        {
            Debug.Log(transform.rotation.z);
            transform.Rotate(new Vector3(0,0,-2*transform.rotation.z*100));
        }
        
    }
}
