﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    
    public int bulletSpeed;

    void FixedUpdate()
    {
        transform.Translate(Vector3.up * Time.deltaTime * bulletSpeed);
    }

}
