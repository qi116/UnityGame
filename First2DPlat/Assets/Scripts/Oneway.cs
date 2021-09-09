using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oneway : MonoBehaviour
{
    private PlatformEffector2D effector;
    private float startWait = 0.25f;
    public float waitTime;

    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
        waitTime = startWait;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Crouch"))
        {
            waitTime = startWait;
            effector.rotationalOffset = 0f;
        }
        if (Input.GetButton("Crouch"))
        {
            if (waitTime <= 0)
            {
                effector.rotationalOffset = 180f;
                waitTime = startWait;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        if (Input.GetButtonDown("Jump"))
        {
            effector.rotationalOffset = 0f;
        }
    }
}
