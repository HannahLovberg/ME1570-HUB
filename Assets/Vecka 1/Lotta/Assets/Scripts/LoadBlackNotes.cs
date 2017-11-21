using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadBlackNotes : MonoBehaviour
{
	public void Changemenuscene(string SharpFlatPlay)
	{
		SceneManager.LoadScene(SharpFlatPlay);
	}
}