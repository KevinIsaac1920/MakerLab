﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("left")){
            gameObject.transform.Translate(-50f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown("right")){
            gameObject.transform.Translate(50f * Time.deltaTime, 0, 0);
        }
    }
 }
