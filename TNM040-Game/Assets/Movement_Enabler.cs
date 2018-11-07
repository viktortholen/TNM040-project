using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Enabler : MonoBehaviour {

    public GameObject Player;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            EnableJump();
        }
    }
    void EnableJump()
    {
        Debug.Log("Jump Enabled");
        Player.GetComponent<PlayerController>().canJump = true;
    }

}
