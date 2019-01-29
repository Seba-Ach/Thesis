using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPortHints : MonoBehaviour
{

    public GameObject hints;

    // Start is called before the first frame update
    void Start()
    {
        hints.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            hints.SetActive(true);
        }

    }

    void OnTriggerExit()
    {
        hints.SetActive(false);
    }


}
