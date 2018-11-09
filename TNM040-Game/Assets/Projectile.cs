using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour {

    public Transform projectilePoint;
    public GameObject bulletPrefab;

    float timeLeft = 2.0f;

    // Update is called once per frame
    void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Shoot();
            timeLeft = 2.0f;
        }
    }

    void Shoot()
    {
        //Shooting logic
        Instantiate(bulletPrefab, projectilePoint.position, projectilePoint.rotation);

    }
}
