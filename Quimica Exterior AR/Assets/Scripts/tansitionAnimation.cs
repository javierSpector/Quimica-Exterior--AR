﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tansitionAnimation : MonoBehaviour
{
    Animator anim;
    public int counter;
    
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            Debug.Log("toma el input!");
            counter++;
            
            anim.SetInteger("animationTransition", counter);
            }
        }
        
        
    }

