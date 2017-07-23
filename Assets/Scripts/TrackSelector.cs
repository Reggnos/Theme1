using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackSelector : MonoBehaviour {

    private int selectedTrackPosition = 0;

    public GameObject selectedTrack;
    public List<GameObject> tracks;
    public Vector2 selectedSize;
    public Vector2 unselectedSize;
    

	// Use this for initialization
	void Start () {
        SelectTrack(selectedTrack);

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("left"))
        {
            GetTrackLeft();
        }
        if (Input.GetKeyDown("right"))
        {
            GetTrackRight();
        }
	}

    void GetTrackLeft()
    {
        if (selectedTrackPosition == 0)
        { 
            SelectTrack(tracks[3]);
            selectedTrackPosition = 3;
        }
        else
        {
            selectedTrackPosition -= 1;
            SelectTrack(tracks[selectedTrackPosition]);
        }
    }

    void GetTrackRight()
    {
        if (selectedTrackPosition == 3)
        {
            SelectTrack(tracks[0]);
            selectedTrackPosition = 0;
        }
        else
        {
            selectedTrackPosition += 1;
            SelectTrack(tracks[selectedTrackPosition]);
        }
    }

    void SelectTrack(GameObject newTrack)
    {
        selectedTrack.transform.localScale = unselectedSize;
        selectedTrack = newTrack;
        newTrack.transform.localScale = selectedSize; 
    }
}
