using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Checkpoint : MonoBehaviour
{

    public LevelManager levelManager;
    public GameObject ps;
    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();

        if (SceneManager.GetActiveScene().buildIndex > 0 && SceneManager.GetActiveScene().buildIndex != 4)
        {
            FindObjectOfType<AudioManager>().Play("soundtrack");
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            FindObjectOfType<AudioManager>().Play("psy");
        }
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
            
            if(SceneManager.GetActiveScene().buildIndex > 0)
            {
                FindObjectOfType<AudioManager>().Play("checkpoint");
            }
           

        }
    }
}