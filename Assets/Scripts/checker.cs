using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class checker : MonoBehaviour {

	// Use this for initialization
	public GameObject  Chulo_vorticella, ChuloProterospongia, ChuloAmeba, ChuloStentor, ChuloColpidium, ChuloGiardia, ChuloEuglena, ChuloParamecium;



	void Start () {
		Chulo_vorticella.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt ("checkvorticela") == 1) {
			Chulo_vorticella.SetActive (true);
		
		} else {
		
			Chulo_vorticella.SetActive (false);
		}


		if (PlayerPrefs.GetInt ("checkeuglena") == 1) {
			ChuloEuglena.SetActive (true);

		} else {

			ChuloEuglena.SetActive (false);
		}


		if (PlayerPrefs.GetInt ("checkparamecium") == 1) {
			ChuloParamecium.SetActive (true);

		} else {

			ChuloParamecium.SetActive (false);
		}


		if (PlayerPrefs.GetInt ("checkgiardia") == 1) {
			ChuloGiardia.SetActive (true);

		} else {

			ChuloGiardia.SetActive (false);
		}


		if (PlayerPrefs.GetInt ("checkstentor") == 1) {
			ChuloStentor.SetActive (true);

		} else {

			ChuloStentor.SetActive (false);
		}

		if (PlayerPrefs.GetInt ("checkameba") == 1) {
			ChuloAmeba.SetActive (true);

		} else {

			ChuloAmeba.SetActive (false);
		}

		if (PlayerPrefs.GetInt ("checkproteros") == 1) {
			ChuloProterospongia.SetActive (true);

		} else {

			ChuloProterospongia.SetActive (false);
		}

		if (PlayerPrefs.GetInt ("checkcolpidium") == 1) {
			ChuloColpidium.SetActive (true);

		} else {

			ChuloColpidium.SetActive (false);
		}

	}
}
