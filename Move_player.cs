﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_player: MonoBehaviour
{

    public float MoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * MoveSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += transform.forward * -1 * MoveSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 5, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -5, 0);
        }
    }
}
