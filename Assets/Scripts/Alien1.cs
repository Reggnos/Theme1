using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien1 : MonoBehaviour {

    public GameObject character;
    private Character characterScript;
    public GameObject otherGameObject;
    private Transform goal;

	
	void Start () {
        goal = otherGameObject.GetComponent<Transform>();
        characterScript = character.GetComponent<Character>();
	}
	    
	
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, goal.transform.position.y), 3 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        characterScript.health -= 1;
        Destroy(gameObject);
    }
}
