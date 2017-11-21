
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextSceneAnneli1 : MonoBehaviour
{
    public void Changemenuscene(string IntervalEasy)
    {
        SceneManager.LoadScene(IntervalEasy);
    }
}
