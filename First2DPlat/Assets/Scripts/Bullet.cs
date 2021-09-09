using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    private float initializationTime;
    void Start()
    {
        rb.velocity = transform.right * speed;
        initializationTime = Time.timeSinceLevelLoad;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        Debug.Log(hitInfo.name);
        string hit = hitInfo.tag;
        if (hit.Equals("Enemy"))
        {
            hitInfo.GetComponent<Enemy>().TakeDamage(damage);
        }
        Destroy(gameObject);

    }
    void Update()
    {
        float timeSinceInitialization = Time.timeSinceLevelLoad - initializationTime; //better to use Invoke("Destroy FUnction", seconds)
        if (timeSinceInitialization > 2) Destroy(gameObject);
    }
}
  

