using UnityEngine;
using System.Collections;

namespace FunFant {
	//Move the boat a little
	public class BoatBehaviour : MonoBehaviour {

		private Vector3 originalLocalPosition;
		public float positionAmount = 0.1f;

		void Start () {
				originalLocalPosition = this.transform.localPosition;
		}

		void Update () {
			transform.localPosition = Vector3.Lerp(transform.localPosition,
			                                       new Vector3( originalLocalPosition.x,
			                                              		originalLocalPosition.y + Mathf.Sin(Time.time)*positionAmount,
			                                                    originalLocalPosition.z),
			                                       				Time.deltaTime*Random.Range(0.95f,1.05f));
		}
	}
}
