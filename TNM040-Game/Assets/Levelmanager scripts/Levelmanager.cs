using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckpoint;

    private PlayerController player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
		
	}

    public void RespawnPlayer()
    {

        player.transform.position = currentCheckpoint.transform.position;
        
    }
}
