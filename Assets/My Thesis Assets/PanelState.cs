using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelState : MonoBehaviour {

    public GameObject panel;

    public void QuitGame()
    {
        Application.Quit();
    }


    void Start()
    {
        panel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            panel.SetActive(true);
        }
    }
}
