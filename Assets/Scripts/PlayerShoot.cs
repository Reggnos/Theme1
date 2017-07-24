using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    private GameObject bullet;
    public GameObject camera;
    private BulletChoose bulletChoose;
    public int projectileSpeed;
    public int amountOfTime;

    private void Start()
    {
        bullet = GetComponent<GameObject>();
        bulletChoose = camera.GetComponent<BulletChoose>();
    }


    void Update ()
    {
        bullet = bulletChoose.bulletChosen;

        if (Input.GetKeyDown("space"))
        {

            GameObject bulletInstance;
            bulletInstance = Instantiate<GameObject>(bullet,transform.position,transform.rotation);
           
            Destroy(bulletInstance, amountOfTime);
           
        }


	}

    
}
