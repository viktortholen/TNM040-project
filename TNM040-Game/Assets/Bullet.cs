using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject ps;
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
            GameObject clone = (GameObject)Instantiate(ps, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.2f);
            Destroy(clone, 1.0f);
        }
        
    }

}
