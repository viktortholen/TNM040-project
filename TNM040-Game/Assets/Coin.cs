using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public gameMaster gm;
    public GameObject CoinParticle;
    // Use this for initialization
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gm.points++;
            if (CoinParticle)
            {
                GameObject clone = (GameObject)Instantiate(CoinParticle, transform.position, Quaternion.identity);
                Destroy(clone, 2.0f);
            }
           
            Destroy(this.gameObject);

            FindObjectOfType<AudioManager>().Play("coin");
            
        }
    }
}
