using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingCollider : MonoBehaviour
{
    public GameObject player;
    public int damagePerSec=1;

    void OnTriggerStay(Collider other)
    {
        if ((player.tag == "Player"))
        {
            PlayerAttributes.currentHP = PlayerAttributes.currentHP-(damagePerSec * Time.deltaTime); 
        }

    }
}
