using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMasterScene : MonoBehaviour
{
	public void Changemenuscene(string BackToMasterScene)
	{
		SceneManager.LoadScene(BackToMasterScene);
	}
}