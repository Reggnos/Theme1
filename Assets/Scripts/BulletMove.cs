using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public GameObject player;
    private float speed ;
    private float timeToShoot;

    private void Start()
    {
        
    }

    void Update()
    {
        timeToShoot += Time.deltaTime;
        if (Input.GetKeyUp("space") || timeToShoot > 3.2) speed = PlayerShoot.projectileSpeed;
        Debug.Log(timeToShoot);
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    
    
}
