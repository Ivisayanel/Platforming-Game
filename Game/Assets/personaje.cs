using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float j_v;
    public float l_v;
    public float r_v;
    private Vector2 actual_vec;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * j_v;
        }

        if (Input.GetKey("a"))
        {
            myRigidbody.velocity = l_v;
        }
    }
}   
