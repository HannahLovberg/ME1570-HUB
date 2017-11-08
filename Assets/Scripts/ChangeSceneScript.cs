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
        Scene hubScene = SceneManager.GetSceneByBuildIndex(0);
        bool isHubScene = SceneManager.GetActiveScene() == hubScene;
		if(!isHubScene && Input.GetKeyDown(KeyCode.Space))
        {
            OnLoadScene(0);
        }
	}

    public void triggered(Collider col)
    {
        switch(col.gameObject.tag)
        {
            //vecka1
            case "Hannah1":
                OnLoadScene(2);
                break;
            case "Sofi1":
                OnLoadScene(3);
                break;
            case "Anneli1":
                OnLoadScene(4);
                break;
            case "Tove1":
                OnLoadScene(5);
                break;
            case "Lotta1":
                OnLoadScene(6);
                break;

            //vecka2
            case "Hannah2":
                OnLoadScene(7);
                break;
            case "Sofi2":
                OnLoadScene(8);
                break;
            case "Anneli2":
                OnLoadScene(9);
                break;
            case "Tove2":
                OnLoadScene(10);
                break;
            case "Lotta2":
                OnLoadScene(11);
                break;

                //Vecka3
            case "Hannah3":
                OnLoadScene(12);
                break;
            case "Sofi3":
                OnLoadScene(13);
                break;
            case "Anneli3":
                OnLoadScene(14);
                break;
            case "Tove3":
                OnLoadScene(15);
                break;
            case "Lotta3":
                OnLoadScene(16);
                break;
        }


        //if (col.gameObject.tag == "Hannah1")
        //{
        //    OnLoadScene(2);
        //}
        //if (col.gameObject.tag == "Sofi1")
        //{
        //    OnLoadScene(3);
        //}
        //if (col.gameObject.tag == "Anneli1")
        //{
        //    OnLoadScene(4);
        //}
        //if (col.gameObject.tag == "Tove1")
        //{
        //    OnLoadScene(5);
        //}
        //if (col.gameObject.tag == "Lotta1")
        //{
        //    OnLoadScene(6);
        //}
    }

    public void OnLoadScene(int sceneIndex)
    {

        nextSceneIndex = sceneIndex;
        SceneManager.LoadScene(1);
    }
}
