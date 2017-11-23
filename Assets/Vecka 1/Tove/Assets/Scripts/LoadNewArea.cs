using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class LoadNewArea : MonoBehaviour
{
    public string LevelToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)

    {
        if(other.gameObject.name == "Player")
        {

            SceneManager.LoadScene(LevelToLoad);
        }

    }
}
