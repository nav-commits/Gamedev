﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour

{
    // speed of the object
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        if (true)

        {
            Debug.Log("hello World!!");

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);
        
    }





}


