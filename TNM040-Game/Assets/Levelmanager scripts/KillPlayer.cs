using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    public LevelManager levelManager;

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            levelManager.RespawnPlayer();
            Time.timeScale = 0;
            StartCoroutine(Delay());
            Time.timeScale = 1;
        }
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        
    }

}
