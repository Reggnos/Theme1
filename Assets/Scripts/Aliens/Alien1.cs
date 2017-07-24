using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien1 : MonoBehaviour {

    public GameObject character;
    private Character characterScript;
    public GameObject otherGameObject;
    private Transform goal;
    private bool isHit = false;
    private Rigidbody2D myRigidbody;
    private BoxCollider2D myBoxCollider;
    private Alien1 myScript;


    void Start() {; 
        myScript = GetComponent<Alien1>();
        myBoxCollider = GetComponent<BoxCollider2D>();
        myRigidbody = GetComponent<Rigidbody2D>();
        goal = otherGameObject.GetComponent<Transform>();
        characterScript = character.GetComponent<Character>();
    }


    void Update()
    {
        if (isHit == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, goal.transform.position.y), 3 * Time.deltaTime);
        }
        else
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            isHit = true;
            myBoxCollider.enabled = false;
            Destroy(myRigidbody);       
        }
        else if (collision.gameObject.tag == "Mix Table")
        {
            characterScript.health -= 1;
            Destroy(gameObject);
        }
    }
}