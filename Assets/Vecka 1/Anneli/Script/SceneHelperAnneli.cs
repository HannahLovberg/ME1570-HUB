using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
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
    void Start()
    {
        DontDestroyOnLoad(this);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnLoadScene(int sceneIndex)
    {
        nextSceneIndex = sceneIndex;
        SceneManager.LoadScene(1);


    }
}