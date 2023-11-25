using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public float JumpStrength;

    public Rigidbody2D myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {/*
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myrigidbody.velocity = Vector2.right * JumpStrength;
        }
     
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myrigidbody.velocity = Vector2.left * JumpStrength;
        }
        */
        
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myrigidbody.velocity = Vector2.up * JumpStrength;

        }
    }
}
