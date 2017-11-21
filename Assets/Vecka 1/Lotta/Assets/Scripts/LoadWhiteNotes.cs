using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadWhiteNotes : MonoBehaviour
{
	public void Changemenuscene(string KeyPlay)
	{
		SceneManager.LoadScene(KeyPlay);
	}
}