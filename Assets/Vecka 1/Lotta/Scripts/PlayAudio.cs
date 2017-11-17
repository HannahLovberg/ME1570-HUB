using UnityEngine;
using System.Collections;

public class PlayAudio : MonoBehaviour{

	AudioSource ac;
	void Start (){
		ac = GetComponent<AudioSource> ();
	}
	void OnMouseDown(){
		ac.PlayOneShot (ac.clip);
	}
}