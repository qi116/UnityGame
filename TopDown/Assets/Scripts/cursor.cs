﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cursor : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;
    }
}
