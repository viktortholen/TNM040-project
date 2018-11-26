using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour {

    public Transform projectilePoint;
    public GameObject bulletPrefab;


    void Shoot()
    {
        //Shooting logic
        Instantiate(bulletPrefab, projectilePoint.position, projectilePoint.rotation);

    }
}
