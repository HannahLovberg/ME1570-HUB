using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{
    private int nextSceneIndex;

    public int NextSceneIndex
    {
        get
        {
            return nextSceneIndex;
        }

        set
        {
            nextSceneIndex = value;
        }
    }

    // Use this for initialization
    void Start ()
    {
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update ()
    {
        int level = Application.loadedLevel;
		if(level != 0 && Input.GetKeyDown(KeyCode.Space))
        {
            OnLoadScene(0);
        }
	}

    void OnTriggerEnter(Collider col)
    {
        //byt till switch
        if (col.gameObject.tag == "Hannah1")
        {
            OnLoadScene(2);
        }
        if (col.gameObject.tag == "Sofi1")
        {
            OnLoadScene(3);
        }
        if (col.gameObject.tag == "Anneli1")
        {
            OnLoadScene(4);
        }
        if (col.gameObject.tag == "Tove1")
        {
            OnLoadScene(5);
        }
        if (col.gameObject.tag == "Lotta1")
        {
            OnLoadScene(6);
        }
    }

    public void OnLoadScene(int sceneIndex)
    {
        nextSceneIndex = sceneIndex;
        SceneManager.LoadScene(1);
    }
}
