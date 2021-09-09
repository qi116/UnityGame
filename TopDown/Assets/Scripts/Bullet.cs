using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 target;
    private Vector2 playerPos;
    private Vector2 direction;
    public float speed;
    private GameObject player;
    private Rigidbody2D rb;
    private CircleCollider2D c;

   
    void Start()
    {
       c= GetComponent<CircleCollider2D>();
        FindObjectOfType<AudioManager>().Play("Shot");

        player = GameObject.FindGameObjectWithTag("Player");
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //playerPos = player.transform.position;//Camera.main.ScreenToWorldPoint(player.transform.position);

        

        //direction = target-playerPos;

        //direction.Normalize();

        
        //rb = GetComponent<Rigidbody2D>();

       // rb.velocity = direction * speed*Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        //To mouse position
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target) <= 0.2f)
        {
            Destroy(gameObject);
        }
        //Continuous movement below
        /*rb.velocity = direction * speed * Time.fixedDeltaTime;
        if (Math.Abs(rb.position.x)> 14 || Math.Abs(rb.position.y)> 6)
        {
            Destroy(gameObject);
        }*/
        /*if ((Vector2)transform.position == target)
        {
            Destroy(gameObject);
        }*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Debug.Log("i");
        }
        else
        {
            Destroy(gameObject);
        }

    }
   

    

}
