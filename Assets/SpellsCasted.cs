using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellsCasted : MonoBehaviour{

    public GameObject fireAttack;
    private Animator anim;
    float counter = 0;
    public GameObject healSpritesR;

    // Start is called before the first frame update
    void Start()
    {
        fireAttack.SetActive(false);
        healSpritesR.SetActive(false);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F) && !(counter<3))
        {
            fireAttack.gameObject.SetActive(true);
            anim.Play("CastingAnim");
            Invoke("fireOff", 2);
        }

        if (Input.GetKey(KeyCode.G) && !(counter<3) && PlayerAttributes.currentHP<90)
        {
            healSpritesR.SetActive(true);
            anim.Play("CastHeal");
            PlayerAttributes.currentHP = PlayerAttributes.currentHP+ 10;
            counter = 0;
            Invoke("healSpritesOff", 2);
        }

        if (counter < 3)
        {
            counter = counter + (1 * Time.deltaTime);
        }
    }

    void fireOff()
    {
        fireAttack.gameObject.SetActive(false);
    }

    void healSpritesOff()
    {
        healSpritesR.SetActive(false);
    }

}
