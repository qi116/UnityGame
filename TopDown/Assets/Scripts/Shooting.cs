using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject shot;
    private Transform player;
    void Start()
    {
        player = GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(shot, player.position, Quaternion.identity);
        }
    }
}
