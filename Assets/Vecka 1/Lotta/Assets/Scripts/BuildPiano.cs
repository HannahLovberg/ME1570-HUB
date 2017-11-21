using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPiano : MonoBehaviour {

	[SerializeField]
	private GameObject Key;
	//[SerializeField]
	//private GameObject bKey;

	public AudioClip[] keySound;


	// Use this for initialization
	void Start () 
	{

		for (int i = 0; i < 52; i++)
		{
			GameObject tempGO = Instantiate(Key, new Vector3(18+0.85f*i,10f,10.74f), new Quaternion());
			tempGO.GetComponent<AudioSource> ().clip = keySound [i];
			Debug.Log (i);
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
