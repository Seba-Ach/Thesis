using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTeleport : MonoBehaviour {

    public GameObject ui;
    public GameObject objTeleported;
    public Transform destLoc;

	// Use this for initialization
	void Start () {
        ui.SetActive(false);
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider other) {
        ui.SetActive(true);
        if((other.gameObject.tag == "Player")&& Input.GetKeyDown(KeyCode.E)){
            objTeleported.transform.position = destLoc.transform.position;
        }
	}

    void OnTriggerExit()
    {
        ui.SetActive(false);
    }
}
