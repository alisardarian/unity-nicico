using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private Vector2 xLimit;
    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Confined;
    }

   
    void Update()
    {
        var newPosition = transform.position;
    
        newPosition.x = Mathf.Clamp(newPosition.x, xLimit.x, xLimit.y);
        
        transform.position = newPosition;
    }


}
