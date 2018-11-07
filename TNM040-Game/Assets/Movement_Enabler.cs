using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Enabler : MonoBehaviour {

    public GameObject Player;
    public bool Left, Right, Jump, Down;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Jump)
            {
                EnableJump();
            }
            if (Down)
            {
                EnableDown();
            }
            if (Left)
            {
                EnableLeft();
            }
            if (Right)
            {
                EnableRight();
            }

        }
    }
    void EnableJump()
    {
        Debug.Log("Jump Enabled");
        Player.GetComponent<PlayerController>().canJump = true;
    }
    void EnableDown()
    {
        Debug.Log("Down Enabled");
        Player.GetComponent<PlayerController>().canDown = true;
    }
    void EnableLeft()
    {
        Debug.Log("Left Enabled");
        Player.GetComponent<PlayerController>().canLeft = true;
    }
    void EnableRight()
    {
        Debug.Log("Right Enabled");
        Player.GetComponent<PlayerController>().canRight = true;
    }

}
