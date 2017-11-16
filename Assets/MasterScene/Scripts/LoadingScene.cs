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
        int nextSceneIndex = 0;
        int prevSceneIndex = 0;
        ChangeSceneScript helper = FindObjectOfType<ChangeSceneScript>();

        if (helper != null)
        {
            nextSceneIndex = helper.NextSceneIndex;
            prevSceneIndex = helper.PrevSceneIndex;
        }

        StartCoroutine(LoadNextScene(nextSceneIndex, prevSceneIndex));
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

    IEnumerator LoadNextScene(int nextSceneIndex, int previousScene)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(nextSceneIndex);

        while (!async.isDone)
        {
            yield return null;
        }  
    }
}
