using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol_water : MonoBehaviour
{

    public float speed;
    private bool movingLeft = true;
    public Transform WallDetection;

    Vector2 direction;

    private void Start()
    {
        direction = Vector2.left;
    }


    void Update()
    {
        this.transform.Translate(Vector2.left * speed * Time.deltaTime);


        RaycastHit2D wallinfo = Physics2D.Raycast(WallDetection.position, direction, 0.1f);


        if (wallinfo.collider.CompareTag("Base") != false)
        {
            if (movingLeft == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingLeft = false;

            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingLeft = true;

            }

        }

    }
}
