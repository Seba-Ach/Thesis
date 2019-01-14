using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellInteract : MonoBehaviour
{

    private Animator anims;
    private CapsuleCollider cap;
    // Start is called before the first frame update
    void Start()
    {
        cap = GetComponent<CapsuleCollider>();
        anims = GetComponent<Animator>();
    }

    void OnTriggerStay(Collider other)
    {
        if ((other.tag == "Spell"))
        {
            Invoke("ZombieDie",1);
        }
    }

    void ZombieDie()
    {
        anims.Play("Dead");
        cap.enabled = false;
    }

}
