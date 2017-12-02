using UnityEngine;
using System.Collections;

namespace FunFant {
	//Randomize emission amount
	public class CoalEmission : MonoBehaviour {
		float random;

		void Update () {
			random = Random.Range(0.0f, 150.0f);
			float noise = Mathf.PerlinNoise(random, Time.time*0.1f);
			float value = Mathf.Lerp (0.3f, 0.8f, noise);
			this.GetComponent<Renderer>().material.SetColor ("_EmissionColor", new Color(value,value,value));
		}
	}
}