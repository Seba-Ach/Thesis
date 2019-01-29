using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowUI : MonoBehaviour {

    public GameObject instructions;
    public GameObject farewell;

	// Use this for initialization
	void Start () {
        instructions.SetActive(false);
        farewell.SetActive(false);
	}

    // Update is called once per frame
    void OnTriggerStay(Collider other) { 
        if ((other.gameObject.tag == "Player") && !(DifferentStates.blueDone && DifferentStates.greenDone && DifferentStates.redDone))
        {
            instructions.SetActive(true);
        }
        else if ((other.gameObject.tag == "Player") && (DifferentStates.blueDone && DifferentStates.greenDone && DifferentStates.redDone))
        {
            farewell.SetActive(true);
        }
    }

    void OnTriggerExit()
    {
        instructions.SetActive(false);
        farewell.SetActive(false);
    }
}
