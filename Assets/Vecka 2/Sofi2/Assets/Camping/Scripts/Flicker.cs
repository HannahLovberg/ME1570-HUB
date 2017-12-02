using UnityEngine;

namespace FunFant {
	//Change light amount and position
	public class Flicker : MonoBehaviour {
		public Light fireLight;
		private Vector3 originalLocalPosition;
		public float intensityMaxValue;
		public float intensityMinValue;
		public float positionChangeMaxValue;

		void Start() {
			originalLocalPosition = fireLight.transform.localPosition;
		}

		void Update () {
			float random = Random.Range(0.5f, 2f);
			fireLight.GetComponent<Light>().intensity = Mathf.Lerp(intensityMinValue, intensityMaxValue, Time.deltaTime*random);

			fireLight.transform.localPosition = new Vector3 (originalLocalPosition.x + Random.Range(-positionChangeMaxValue, positionChangeMaxValue), 
			                                                 originalLocalPosition.y + Random.Range(-positionChangeMaxValue, positionChangeMaxValue),
			                                                 originalLocalPosition.z + Random.Range(-positionChangeMaxValue, positionChangeMaxValue));
		}
	}
}