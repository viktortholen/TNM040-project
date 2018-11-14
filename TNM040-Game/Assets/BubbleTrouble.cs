using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleTrouble : MonoBehaviour {

    public GameObject Player;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.GetComponent<Rigidbody2D>().gravityScale = -0.5f;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.GetComponent<Rigidbody2D>().gravityScale = 1f;
        }
    }



}
