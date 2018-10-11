using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScriptFairies : MonoBehaviour {

    [SerializeField] AudioSource fairies;

	// Use this for initialization
	void Start () {
        fairies = GetComponent<AudioSource>();
        fairies.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
