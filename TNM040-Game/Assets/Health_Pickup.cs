using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Pickup : MonoBehaviour {

    public GameObject ps;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            GameControlScript.health += 1;
            GameObject clone = (GameObject)Instantiate(ps, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(clone, 1.0f);
      
        }

    }
}
