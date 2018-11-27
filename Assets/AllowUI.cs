using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowUI : MonoBehaviour {

    public GameObject instructions;

	// Use this for initialization
	void Start () {
        instructions.SetActive(false);
	}

    // Update is called once per frame
    void OnTriggerStay(Collider other) { 
        if ((other.gameObject.tag == "Player"))
        {
            instructions.SetActive(true);
        }
    }

    void OnTriggerExit()
    {
        instructions.SetActive(false);
    }
}
