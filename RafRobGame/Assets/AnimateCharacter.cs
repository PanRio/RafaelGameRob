using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCharacter : MonoBehaviour
{
    static Animator anim;
    public float animTrans = 5.0f;
    public float speed = 5.0f;
    public float rotationSpeed = 75.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (translation != 0)
        {
            
            anim.SetFloat("Blend", Mathf.Lerp(0,1,animTrans*Time.deltaTime));
        }
        else
        {
            anim.SetFloat("Blend", Mathf.Lerp(1,0,animTrans*Time.deltaTime));
        }
    }
}