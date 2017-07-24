using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject bullet;
    public GameObject scriptObject;
    public GameObject bulletInstance;
    public BulletChoose bulletChoose;   
    public int amountOfTimeTillDestroyed;
    public static float projectileSpeed;
    public static float Hold;
    bool wasDown;
    


    private void Start()
    {

        bulletChoose = scriptObject.GetComponent<BulletChoose>();
        
    }


    void Update ()
    {
        bullet = bulletChoose.bulletChosen;


        if (Input.GetKeyDown("space"))
        {
            MakeAndBreak();
            wasDown = true;

        }
        else if (Input.GetKey("space") && Hold < 3 && wasDown)
        {
            Hold += Time.deltaTime;
            bulletInstance.transform.localScale += new Vector3(0.015f, 0.015f, 0.015f);
            
        }
        else if(Input.GetKeyUp("space") || Hold > 3)
        {
            Destroy(bulletInstance, amountOfTimeTillDestroyed);
            projectileSpeed = 5 - Hold;
            Hold = 0;
            wasDown = false;
        }


    }

    void MakeAndBreak()
    {       
        bulletInstance = Instantiate<GameObject>(bullet, transform.position, transform.rotation);
       
    }
    
  

    
}
