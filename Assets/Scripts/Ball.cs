using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Ball : MonoBehaviour
{
    [FormerlySerializedAs("rigidbody2D")] [SerializeField] private Rigidbody2D rb;

    private void OnEnable()
    {
        
    }
    

    [SerializeField] private float power;
    // Start is called before the first frame update
    void Start()
    {
        //add initial force
        rb.AddForce(Vector2.down*power);
    }

    private void Update()
    {
        
    }
}
