using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aelia_Movement : MonoBehaviour
{
    Rigidbody2D rb; //access sto rigid body
    public float speed = 3f; //Sprite Speed
    public float jump_speed = 0.02f; //Jump Speed
    public float limit = 10;
    public float neglimit = -10;
    public float limity = 4;
    public float neglimity = -4;
    float jumpSpeed = 6; //jump height
    float jumpForward = 1;


    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x>=limit)
        {
            Vector3 v = transform.position;
            v.x = limit;
            transform.position = v;
        }
        
        if (transform.position.x <= neglimit)
        {
            Vector3 v = transform.position;
            v.x = neglimit;
            transform.position = v;
        }

        if (transform.position.y >= limity)
        {
            Vector3 v = transform.position;
            v.y = limity;
            transform.position = v;
        }

        if (transform.position.y <= neglimity)
        {
            Vector3 v = transform.position;
            v.y = neglimity;
            transform.position = v;
        }

        /*if (Input.GetAxis("Horizontal") * speed * Time.deltaTime > 0)
        {
            transform.localScale=Vector3(-1, 1, 1);
        }
        if (Input.GetAxis("Horizontal") * speed * Time.deltaTime > 0)
        {
            transform.localScale=Vector3(1, 1, 1);
        }*/
        

        transform.Translate(Input.GetAxis("Horizontal")*speed*Time.deltaTime, 0, 0, Space.World);
        //transform.Translate(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(0, jump_speed, 0,Space.World);
        }

    }
    void FixedUpdate()
    {
        /*if (Input.GetButtonDown("Fire1"))
        {
            rb.velocity = new Vector2(jumpForward, jumpSpeed);
        }*/





    }
}
