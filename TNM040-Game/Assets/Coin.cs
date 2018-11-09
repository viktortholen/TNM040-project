using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public gameMaster gm;
    // Use this for initialization
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            gm.points++;
        }
    }
}
