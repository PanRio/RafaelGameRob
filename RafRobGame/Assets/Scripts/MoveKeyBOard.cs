﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKeyBOard : MonoBehaviour
{
    public float speed = 1f;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Translate(new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"))*speed);


    }
}
