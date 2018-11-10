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
            Instantiate(CoinParticle, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            gm.points++;
        }
    }
}
