using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{

    public static int health;
    public static int score;

    public Text scoreText;
    public Text healthText;

    private Text txt1, txt2;

    void Start()
    {
        health = 10;
        score = 0;
    }

    // Use this for initialization
    void Awake()
    {
        txt1 = scoreText.GetComponent<Text>();
        txt2 = healthText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt1.text = "Score is: " + score;
        txt2.text = "Health: " + health;
    }
}