using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Alien1 : MonoBehaviour {

    public GameObject otherGameObject;
    public GameObject character;
    public float walkSpeed = 3.0f;

    private string levelName = "Game Over" ;
    private Character characterScript;
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
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, goal.transform.position.y), walkSpeed * Time.deltaTime);
        }
        else
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "AlienDisco" && collision.gameObject.tag == "BulletDisco")
        {
            isHit = true;
            myBoxCollider.enabled = false;
            Destroy(myRigidbody);
            Character.score++;
            Destroy(collision.gameObject);
        }
        else if (gameObject.tag == "AlienMetal" && collision.gameObject.tag == "BulletMetal")
        {
            isHit = true;
            myBoxCollider.enabled = false;
            Destroy(myRigidbody);
            Character.score++;
            Destroy(collision.gameObject);
        }
        else if (gameObject.tag == "AlienTechno" && collision.gameObject.tag == "BulletTechno")
        {
            isHit = true;
            myBoxCollider.enabled = false;
            Destroy(myRigidbody);
            Character.score++;
            Destroy(collision.gameObject);
        }
        else if (gameObject.tag == "AlienClassic" && collision.gameObject.tag == "BulletClassic")
        {
            isHit = true;
            myBoxCollider.enabled = false;
            Destroy(myRigidbody);
            Character.score++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Mix Table")
        {
            if (Character.health > 0)
            {
                Character.health -= 1;
                Destroy(gameObject);
            }
            else
            {
                SceneManager.LoadScene(levelName);
            }
        }
    }
}