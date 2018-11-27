using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalsActivity : MonoBehaviour {

    public GameObject redport;
    public GameObject greenport;
    public GameObject blueport;

    public GameObject redring;
    public GameObject greenring;
    public GameObject bluering;


    // Use this for initialization
    void Start () {
        redport.SetActive(true);
        greenport.SetActive(true);
        blueport.SetActive(true);

        redring.SetActive(false);
        greenring.SetActive(false);
        bluering.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (DifferentStates.redDone)
        {
            redport.SetActive(false);
            redring.SetActive(true);
        }

        if (DifferentStates.greenDone)
        {
            greenport.SetActive(false);
            greenring.SetActive(true);
        }

        if (DifferentStates.blueDone)
        {
            blueport.SetActive(false);
            bluering.SetActive(true);
        }
    }
}
