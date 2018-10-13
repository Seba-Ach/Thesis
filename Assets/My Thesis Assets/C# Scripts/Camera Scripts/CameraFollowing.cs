﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = player.transform.position;
        //transform.rotation = player.transform.rotation; //if ever used camera angle should be changed.
    }
}
