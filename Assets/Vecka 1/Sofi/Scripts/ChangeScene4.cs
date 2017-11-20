using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene4 : MonoBehaviour
{
    public void Changemenuscene(string SouthPole)
    {
        SceneManager.LoadScene(SouthPole);
    }
}
