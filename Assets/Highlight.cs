using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour 
{

	GameObject[] hightlightNotes; //D D A A B B A
	int noteIndex;

	public void NextNote()
	{
		hightlightNotes[noteIndex].SetActive(false);

		noteIndex++;
		hightlightNotes[noteIndex].SetActive(true);

		if(noteIndex >= hightlightNotes.Length)
			noteIndex = 0;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}





