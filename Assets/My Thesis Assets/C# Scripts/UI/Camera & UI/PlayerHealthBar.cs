using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class PlayerHealthBar : MonoBehaviour
{

    RawImage healthBarRawImage;
    PlayerAttributes player;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerAttributes>();
        healthBarRawImage = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        float hpPerc = -(player.getHPPercent / 2f) - 0.5f;
        healthBarRawImage.uvRect = new Rect(hpPerc, 0f, 0.5f, 1f);
    }
}
