using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene3 : MonoBehaviour
{
    public void Changemenuscene(string NorthAndSouthAmerica)
    {
        SceneManager.LoadScene(NorthAndSouthAmerica);
    }
}