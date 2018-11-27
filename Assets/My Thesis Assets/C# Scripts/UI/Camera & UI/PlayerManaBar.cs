using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class PlayerManaBar : MonoBehaviour
{

    RawImage manaBarRawImage;
    PlayerAttributes player;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerAttributes>();
        manaBarRawImage = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        float manaPerc = -(player.getManaPercent / 2f) - 0.5f;
        manaBarRawImage.uvRect = new Rect(manaPerc, 0f, 0.5f, 1f);
    }
}
