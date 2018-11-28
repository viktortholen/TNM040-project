using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    public float speed;
    private bool movingRight = true;
    public Transform GroundDetection;
    public GameObject Light;

    Vector2 direction;

    private void Start()
    {
        direction = Vector2.right;
    }


    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(GroundDetection.position, Vector2.down, 2f);
        RaycastHit2D wallinfo = Physics2D.Raycast(GroundDetection.position, direction, 0.1f);


        if (groundInfo.collider == false || wallinfo.collider.CompareTag("Base") != false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                if (Light)
                {
             
                    Vector3 temp = new Vector3(0, 0, 4f);
                    Light.transform.position += temp;
                }

                
                movingRight = false;

            }
            else
            {
                if (Light)
                {
                    Vector3 temp = new Vector3(0, 0, 4f);
                    Light.transform.position -= temp;
                }

                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;

            }

        }

    }

}
