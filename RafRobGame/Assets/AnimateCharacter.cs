using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCharacter : MonoBehaviour
{
    Vector3 pos;
    public float treshHold = 0.05f;
    static Animator anim;
    public float animTrans = 5.0f;
    public float speed = 5.0f;
    public float rotationSpeed = 75.0f;

    public float blendDividion = 1;

    float BlendAnim;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

        BlendAnim = 0;
        
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        pos = rb.position;
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {

        var input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));



        float vel = Vector3.Distance(pos,rb.position);
        //Debug.Log(vel);
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        

        Quaternion targetRotation = new Quaternion(0,0,0,0);

        if (input != Vector3.zero)
        {
            targetRotation = Quaternion.LookRotation(input);

        }
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        // transform.Rotate(0, rotation, 0);
        Debug.Log(input);
        
        transform.Translate(0,0,input.magnitude*speed*Time.fixedDeltaTime);
        if (input.magnitude != 0 && vel > treshHold) 
        {
            if (BlendAnim < 1) BlendAnim += 1 / blendDividion;
           
        }
        else
        {
            if (BlendAnim > 0) BlendAnim -= 1 / blendDividion;
           
        }
        anim.SetFloat("Blend", input.magnitude);
        pos = rb.position;
    }
}