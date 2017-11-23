using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour
{
    [SerializeField]
    private Text loadingText;

	// Use this for initialization
	void Start ()
    {
        string nextSceneName = "materScene";
        string prevSceneName = "materScene";
        ChangeSceneScript helper = FindObjectOfType<ChangeSceneScript>();

        if (helper != null)
        {
            nextSceneName = helper.NextSceneName;
            prevSceneName = helper.PrevSceneName;
        }

        StartCoroutine(LoadNextScene(nextSceneName, prevSceneName));
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (loadingText != null)
        {
            Color currentColor = loadingText.color;
            currentColor.a = Mathf.PingPong(Time.time, 1);
            loadingText.color = currentColor;
        }
    }

    IEnumerator LoadNextScene(string nextSceneName, string prevSceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextSceneName);
        bool unloaded = SceneManager.UnloadScene(prevSceneName);

        while (!asyncLoad.isDone &&!unloaded)
        {
            yield return null;
        }  
    }
}
