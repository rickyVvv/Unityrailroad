﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [Tooltip("Inms^-1")] [SerializeField] float Speed=20f;
    [Tooltip("In m")] [SerializeField] float xRange=8f;
    [Tooltip("In m")] [SerializeField] float yRange=5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xThrow = Input.GetAxis("Horizontal");
        float yThrow = Input.GetAxis("Vertical");

        float xOffset = xThrow * Speed * Time.deltaTime;
        float yOffset = yThrow *  Speed * Time.deltaTime;

        float xPos = transform.localPosition.x + xOffset;
        float yPos = transform.localPosition.y + yOffset;

        float POSITION= Mathf.Clamp(xPos, -xRange, xRange); //this will stop the position of the ship from exceeding -8 or 8 on the x value
        float POSITIONy= Mathf.Clamp(yPos, -yRange, yRange); 

        transform.localPosition= new Vector3(POSITION, POSITIONy, transform.localPosition.z); // this is so we dont change our x or y position

    }
}
