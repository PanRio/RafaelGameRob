using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnt2 : MonoBehaviour
{
    public float speed = 0.01f;
    private Vector3 move;
    public Transform player;


    private void calcualte()
    {/*
        move.x = (transform.position.x - player.position.x);
        move.y = 0;
        move.z =(transform.position.z - player.position.z);
        */
        move.x = (player.position.x-transform.position.x);
        move.y = 0;
        move.z = (player.position.z-transform.position.z );
        move.Normalize();
        move *= speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        calcualte();
        Debug.Log(move);
        //Debug.Log(move);
        transform.Translate(move);
    }
}
