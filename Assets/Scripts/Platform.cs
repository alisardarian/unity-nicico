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

    // Update is called once per frame
    void Update()
    {
        var mousePos = Input.mousePosition;
        
        //convert to world position:
        var mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);

        var newPosition = new Vector3(mouseWorldPos.x, transform.position.y, transform.position.z);

        newPosition.x = Mathf.Clamp(newPosition.x, xLimit.x, xLimit.y);
        
        transform.position = newPosition;
    }
}
