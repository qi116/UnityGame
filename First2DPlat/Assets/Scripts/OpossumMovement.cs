using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpossumMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float changeDir = 2f;
    public float walkSpeed = 3f;
    public int right = -1;
    public Rigidbody2D opossum;
    // Update is called once per frame
    void Update()
    {
        changeDir -= Time.deltaTime;
        if(changeDir <= 0)
        {
            Flip();
            changeDir = 2f;
        }
        opossum.velocity = new Vector2(right*walkSpeed, 0f);

    }
    private void FixedUpdate()
    {
        opossum.AddForce(new Vector2(Input.GetAxisRaw("Horizontal")*walkSpeed, 0f));
    }
    void Flip()
    {
        transform.Rotate(0f, 180f, 0f);
        right *= -1;

    }
}
