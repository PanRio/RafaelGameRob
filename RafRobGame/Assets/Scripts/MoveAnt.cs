using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnt : MonoBehaviour
{

    public float speed = 0.01f;
    private Vector3 move;
    public Transform player;
    public int motionX = 2,	motionZ = 2;

    private void calcualte()
    {

        if (transform.position.z - motionZ > player.position.z)
        {
            if (transform.position.x  - motionX > player.position.x)
            {
                Debug.Log("góra_lewo");
                if (motionX > 0)
                    motionX *= -1;
                if (motionZ > 0)
                    motionZ *= -1;
            }
            else
            {
                Debug.Log("góra_prawo");
                if (motionX < 0)
                    motionX *= -1;
                if (motionZ > 0)
                    motionZ *= -1;

            }
        }
        else
        {
            if (transform.position.x  - motionX > player.position.x)
            {
                Debug.Log("dół_lewo");
                if (motionX > 0)
                    motionX *= -1;
                if (motionZ < 0)
                    motionZ *= -1;

            }
            else
            {
                Debug.Log("dół_prawo");
                if (motionX < 0)
                    motionX *= -1;
                if (motionZ < 0)
                    motionZ *= -1;

            }
        }

    }

    private void calcualte2()
    {

    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        calcualte();

        move.x = motionX*speed;
        move.y = 0;
        move.z = motionZ * speed;


        //Debug.Log(move);
        transform.Translate(move);
    }
}
