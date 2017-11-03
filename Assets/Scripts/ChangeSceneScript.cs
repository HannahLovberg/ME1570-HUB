using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneScript : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        int level = Application.loadedLevel;
		if(level != 0 && Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel(0);
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Hannah1")
        {
            Application.LoadLevel(1);
        }
        if (col.gameObject.tag == "Sofi1")
        {
            Application.LoadLevel(2);
        }
        if (col.gameObject.tag == "Anneli1")
        {
            Application.LoadLevel(3);
        }
        if (col.gameObject.tag == "Tove1")
        {
            Application.LoadLevel(4);
        }
        if (col.gameObject.tag == "Lotta1")
        {
            Application.LoadLevel(5);
        }
    }
}
