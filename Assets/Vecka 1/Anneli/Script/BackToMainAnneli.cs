using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainAnneli : MonoBehaviour
{
    public void Changemenuscene(string Anneli1)
    {
        SceneManager.LoadScene(Anneli1);
    }
}