using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
	public void Changemenuscene(string Lotta1)
	{
		SceneManager.LoadScene(Lotta1);
	}
}