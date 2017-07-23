using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    
    public float moveSpeed = 1;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        bool left = Input.GetKey("a");
        bool right = Input.GetKey("d");

       
        if(left && (transform.rotation.z < 0.5f))
        {
            transform.Rotate(new Vector3(0,0,1) * moveSpeed * Time.deltaTime);
        }
        if (right && (transform.rotation.z > -0.5f))
        {
            transform.Rotate(new Vector3(0, 0, -1) * moveSpeed * Time.deltaTime);
        }
        
    }
}
