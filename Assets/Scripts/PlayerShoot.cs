using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject bullet;
    public int projectileSpeed;
    public int amountOfTime;
	
	void Update ()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject bulletInstance;
            bulletInstance = Instantiate<GameObject>(bullet,transform.position,transform.rotation);
           
            Destroy(bulletInstance, amountOfTime);
           
        }


	}

    
}
