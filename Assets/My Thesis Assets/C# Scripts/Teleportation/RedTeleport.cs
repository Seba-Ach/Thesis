using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTeleport : MonoBehaviour {

    public GameObject ui;
    public GameObject loadingScrn;
    public GameObject objTeleported;
    public Transform destLoc;

	// Use this for initialization
	void Start () {
        ui.SetActive(false);
        loadingScrn.SetActive(false);
	}
	
	void OnTriggerStay (Collider other) {
        ui.SetActive(true);
        if((other.gameObject.tag == "Player")&& Input.GetKeyDown(KeyCode.E)){
            TeleportPromted();
        }
	}

    void TeleportPromted()
    {
        ui.SetActive(false);
        loadingScrn.SetActive(true);
        Invoke("PosChanger", 2);
        loadingScrn.SetActive(false);
    }

    void PosChanger()
    {
        objTeleported.transform.position = destLoc.transform.position;
    }

    void OnTriggerExit()
    {
        ui.SetActive(false);
    }
}
