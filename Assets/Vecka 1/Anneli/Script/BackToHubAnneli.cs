using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToHubAnneli : MonoBehaviour
{
    public void Changemenuscene(string MasterScene)
    {
        SceneManager.LoadScene(MasterScene);
    }
}

