using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene2 : MonoBehaviour
{
    public void Changemenuscene(string Australia)
    {
        SceneManager.LoadScene(Australia);
    }
}
