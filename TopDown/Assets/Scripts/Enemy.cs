using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Transform playerPos;
    private Player player;
    public GameObject deathEffect;
    private Stats stats;
    private Shake shake;
    void Start()
    {
        shake = GameObject.Find("Shake").GetComponent<Shake>();
        stats = GameObject.Find("Stats").GetComponent<Stats>();
        
        
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Die();
            stats.resetMult();
            player.health--;
            shake.callShake();
            Destroy(gameObject);
            
            
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Die();
            stats.addMult();
            stats.addScore(100);

            Destroy(collision.gameObject);
            Destroy(gameObject);
            stats.Flash();
            
        }
    }
    void Die()
    {
        FindObjectOfType<AudioManager>().Play("Death");
        Instantiate(deathEffect, transform.position, Quaternion.identity);
    }
    
}
