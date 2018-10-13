using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorSettings : MonoBehaviour {

    [SerializeField] Texture2D AttCrsr = null;
    [SerializeField] Texture2D NtrlCrsr = null;
    [SerializeField] Texture2D NtrlClickCrsr = null;
    [SerializeField] Vector2 cursorHotSpot = new Vector2(50,50);

    CameraRaycaster cRayCaster;
    
	// Use this for initialization
	void Start () {
        cRayCaster = GetComponent<CameraRaycaster>();
	}
	
	// Update is called once per frame
	void Update () {
        if (cRayCaster.layerHit == Layer.Enemy)
        {
            Cursor.SetCursor(AttCrsr, cursorHotSpot, CursorMode.Auto);
        }
        else
        {
            Cursor.SetCursor(NtrlCrsr, cursorHotSpot, CursorMode.Auto);
            if (Input.GetMouseButton(0))
            {
                Cursor.SetCursor(NtrlClickCrsr, cursorHotSpot, CursorMode.Auto);
            }
        }
        
	}
}
