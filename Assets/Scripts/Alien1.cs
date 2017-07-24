using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien1 : MonoBehaviour {

    public GameObject character;
    private Character characterScript;
    public GameObject otherGameObject;
    private Transform goal;

<<<<<<< HEAD
	// Use this for initialization
	void Start ()
    {
=======
	
	void Start () {
>>>>>>> db8002ca4e675fa227c3903b4263cfef6350baf4
        goal = otherGameObject.GetComponent<Transform>();
        characterScript = character.GetComponent<Character>();
	}
	    
<<<<<<< HEAD
	// Update is called once per frame
	void Update ()
    {
=======
	
	void Update () {
>>>>>>> db8002ca4e675fa227c3903b4263cfef6350baf4
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, goal.transform.position.y), 3 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        characterScript.health -= 1;
        Destroy(gameObject);
    }
}
