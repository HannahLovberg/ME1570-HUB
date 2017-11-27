using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnAwake( )
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
