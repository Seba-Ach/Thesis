using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToFinal : MonoBehaviour
{

    public GameObject ui;
    public GameObject loadingScrn;


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
        ui.SetActive(false);
        loadingScrn.SetActive(true);
        Invoke("LoadFinal", 2);

    }

    void LoadFinal()
    {
        SceneManager.LoadScene("Final");
        ThirdPersonCameraMouseInputController.loadingScrn = false;
        Cursor.visible = true;
    }

    void OnTriggerExit()
    {
        ui.SetActive(false);
    }
}
