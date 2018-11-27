using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportFinishedBlue : MonoBehaviour
{

    public GameObject ui;
    public GameObject loadingScrn;
    public GameObject objTeleported;
    public Transform destLoc;


    // Use this for initialization
    void Start()
    {
        ui.SetActive(false);
        loadingScrn.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        ui.SetActive(true);
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.E))
        {
            ThirdPersonCameraMouseInputController.loadingScrn = true;
            Cursor.visible = false;
            TeleportPromted();
        }
    }

    void TeleportPromted()
    {
        DifferentStates.blueDone = true;
        ui.SetActive(false);
        loadingScrn.SetActive(true);
        Invoke("PosChanger", 2);

    }

    void PosChanger()
    {
        objTeleported.transform.position = destLoc.transform.position;
        objTeleported.transform.rotation = destLoc.transform.rotation;
        loadingScrn.SetActive(false);
        ThirdPersonCameraMouseInputController.loadingScrn = false;
        Cursor.visible = true;
    }

    void OnTriggerExit()
    {
        ui.SetActive(false);
    }
}
