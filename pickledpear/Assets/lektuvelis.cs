﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lektuvelis : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       float xaxis = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * xaxis);
    }
}
