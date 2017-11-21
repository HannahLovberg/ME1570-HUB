using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSong1 : MonoBehaviour
{
	public void Changemenuscene(string Song1)
	{
		SceneManager.LoadScene(Song1);
	}
}