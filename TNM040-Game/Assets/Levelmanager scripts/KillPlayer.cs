using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    public LevelManager levelManager;

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
        
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(this.tag == "Bullet")
            {
                levelManager.RespawnPlayer();
                GameControlScript.health -= 0.5;
            }
            else
            {
                levelManager.RespawnPlayer();
                GameControlScript.health -= 1;
            }
            

        }
    }


}
