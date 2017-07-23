using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawnManager : MonoBehaviour {

    public GameObject[] enemies;
    private GameObject enemyToSpawn;
    public GameObject pos1;
    public GameObject pos2;
    private Vector3 randomX;

	// Use this for initialization
	void Start () {
        Invoke("SpawnEnemy" , 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnEnemy()
    {
        randomX = new Vector3(Random.Range(pos1.transform.position.x, pos2.transform.position.x), transform.position.y);
        enemyToSpawn = enemies[0];
        Instantiate(enemyToSpawn);
        enemyToSpawn.transform.position = randomX;
        Invoke("SpawnEnemy", 1);
    }
}
