using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarewellPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject farewell;

    // Start is called before the first frame update
    void Start()
    {
        farewell.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            farewell.SetActive(true);
        }

    }

    void OnTriggerExit()
    {
        farewell.SetActive(false);
    }
}
