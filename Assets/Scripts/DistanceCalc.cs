using UnityEngine;
using System.Collections;

public class DistanceCalc : MonoBehaviour {
	public GameObject sphere1;
	public GameObject sphere2;
	public GameObject L;
	public GameObject LF1;
	public GameObject LF2;
	public GameObject LF3;


	//public GameObject atomicbomb;
	// Use this for initialization
	void Start () {
		L.SetActive(false);
		LF1.SetActive(false);
		LF2.SetActive(false);
		LF3.SetActive(false);


	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance (sphere1.transform.position, sphere2.transform.position);

		if (distance > 10) {
		//	AudioSource audio = GetComponent<AudioSource>();
		//	audio.Play();
		}
		if (distance > 150) {
			Debug.Log ("Level 6");
			L.SetActive(false);
			LF1.SetActive(false);
			LF2.SetActive(false);
			LF3.SetActive(false);

		}
		if (150 <= distance && distance < 180) {
			Debug.Log ("Level 5");
			L.SetActive(true);
			LF1.SetActive(false);
			LF2.SetActive(false);
			LF3.SetActive(false);

		}
		if (80 <= distance && distance < 150) {
			Debug.Log ("Level 4");
			L.SetActive(true);
			LF1.SetActive(true);
			LF2.SetActive(false);
			LF3.SetActive(false);
		
		}
		if (60 <= distance && distance < 80) {
			Debug.Log ("Level 3");
			L.SetActive(true);
			LF1.SetActive(true);
			LF2.SetActive(true);
			LF3.SetActive(false);

		}

		if (0 <= distance && distance < 60) {
			Debug.Log ("Level 4");
			L.SetActive(true);
			LF1.SetActive(true);
			LF2.SetActive(true);
			LF3.SetActive(true);

		}
	

		Debug.Log (distance);
	}
}
