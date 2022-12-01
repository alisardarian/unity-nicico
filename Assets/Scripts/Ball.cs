using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Ball : MonoBehaviour
{
     private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    

    [SerializeField] private float power;
    // Start is called before the first frame update
    void Start()
    {
        //add initial force
        rb.AddForce(Vector2.one*power);
    }

    private void Update()
    {
        
    }
}
