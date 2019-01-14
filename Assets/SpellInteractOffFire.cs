using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellInteractOffFire : MonoBehaviour
{

    private Animator anims;
    public GameObject fires;
    // Start is called before the first frame update
    void Start()
    {
        anims = GetComponent<Animator>();
        fires.SetActive(true);
    }

    void OnTriggerStay(Collider other)
    {
        if ((other.tag == "Spell"))
        {
            Invoke("ZombieDie", 1);
        }
    }

    void ZombieDie()
    {
        anims.Play("Dead");
        fires.SetActive(false);
        cap.enabled = false;
    }

}