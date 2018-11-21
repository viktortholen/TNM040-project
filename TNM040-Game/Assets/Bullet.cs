using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;
    public bool Left = false;
	// Use this for initialization
	void Start () {
        if (Left)
        {
            rb.velocity = -transform.right * speed;
        }
        else
        {
            rb.velocity = transform.right * speed;
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        if(hitInfo.CompareTag("Player") || hitInfo.CompareTag("Props"))
        {
            Destroy(gameObject);
        }
        
    }

}
