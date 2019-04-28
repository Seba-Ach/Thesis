using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishItAll : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            DifferentStates.blueDone = true;
            DifferentStates.greenDone = true;
            DifferentStates.redDone = true;
        }
    }
}
