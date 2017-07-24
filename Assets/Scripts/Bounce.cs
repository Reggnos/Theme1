using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Wall")
        {
            transform.Rotate(new Vector3(0,0,-2*transform.rotation.z*100));
        }
        
    }
}
