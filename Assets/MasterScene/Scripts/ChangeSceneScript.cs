using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{
    private string nextSceneName;
    private string prevSceneName;
    

    public string NextSceneName
    {
        get
        {
            return nextSceneName;
        }

        set
        {
            nextSceneName = value;
        }
    }

    public string PrevSceneName
    {
        get
        {
            return prevSceneName;
        }

        set
        {
            prevSceneName = value;
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
  //      int level = SceneManager.GetActiveScene().buildIndex;
  //      Scene hubScene = SceneManager.GetSceneByBuildIndex(0);
  //      bool isHubScene = SceneManager.GetActiveScene() == hubScene;
		//if(!isHubScene && Input.GetKeyDown(KeyCode.Space))
  //      {
  //          OnLoadScene("MasterScene");
  //      }
	}

    public void triggered(Collider col)
    {
        switch(col.gameObject.tag)
        {
            //vecka1
            case "Hannah1":
                OnLoadScene("HannahSpel1");
                break;
            case "Sofi1":
                OnLoadScene("Sofi1");
                break;
            case "Anneli1":
                OnLoadScene("Anneli1");
                break;
            case "Tove1":
                OnLoadScene("main");
                break;
            case "Lotta1":
                OnLoadScene("Lotta1");
                break;

            //vecka2
            case "Hannah2":
                OnLoadScene("Hannah2");
                break;
            case "Sofi2":
                OnLoadScene("Sofi2");
                break;
            case "Anneli2":
                OnLoadScene("Anneli2");
                break;
            case "Tove2":
                OnLoadScene("Tove2");
                break;
            case "Lotta2":
                OnLoadScene("Lotta2");
                break;

                //Vecka3
            case "Hannah3":
                OnLoadScene("Hannah3");
                break;
            case "Sofi3":
                OnLoadScene("Sofi3");
                break;
            case "Anneli3":
                OnLoadScene("Anneli3");
                break;
            case "Tove3":
                OnLoadScene("Tove3");
                break;
            case "Lotta3":
                OnLoadScene("Lotta3");
                break;
        }

    }

    public void OnLoadScene(string sceneName)
    {
        prevSceneName = SceneManager.GetActiveScene().name;
        nextSceneName = sceneName;
        SceneManager.LoadScene(sceneName);
        
    }

    public void goBackToHub()
    {
        OnLoadScene("MasterScene");
    }
}
