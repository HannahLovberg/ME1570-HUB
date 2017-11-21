using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextSceneAnneli : MonoBehaviour
{
    public void Changemenuscene(string IntervallScen1)
    {
        SceneManager.LoadScene(IntervallScen1);
    }
}