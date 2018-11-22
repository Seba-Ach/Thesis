using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] float maxHP = 100f;
    [SerializeField] float maxMana = 500f;
    float currentHP = 100f;
    float currentMana = 500f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public float getHPPercent
    {
        get
        {
            return currentHP / maxHP;
        }
    }

    public float getManaPercent
    {
        get
        {
            return currentMana / maxMana;
        }
    }
}
