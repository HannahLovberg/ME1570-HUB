using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene5 : MonoBehaviour
{
    public void Changemenuscene(string EuropeOrAfrica)
    {
        SceneManager.LoadScene(EuropeOrAfrica);
    }
}
