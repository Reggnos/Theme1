using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletChoose : MonoBehaviour
{
    private TrackSelector trackSelector;
    private int selectedTrackNum;
    public GameObject bulletChosen;
    public GameObject[] bulletArray;

    void Start ()
    {
        trackSelector = GetComponent<TrackSelector>();
    }
	
	void Update ()
    {
        selectedTrackNum = trackSelector.selectedTrackPosition;

        switch (selectedTrackNum)
        {
            case 0: bulletChosen = bulletArray[0];
                    break;
            case 1: bulletChosen = bulletArray[1];
                break;
            case 2: bulletChosen = bulletArray[2];
                break;
            case 3: bulletChosen = bulletArray[3];
                break;

        }
            
	}
}
