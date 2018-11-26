using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    public LevelManager levelManager;
    public GameObject ps;
    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            if (ps && levelManager.currentCheckpoint != this.gameObject)
            {
      
                GameObject clone = (GameObject)Instantiate(ps, transform.position, Quaternion.identity);
                Destroy(clone, 1.0f);
            }
            levelManager.currentCheckpoint = gameObject;

           

        }
    }
}