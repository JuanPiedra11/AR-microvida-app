using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enviarinfo : MonoBehaviour {

	public GameObject btninfo;
	public GameObject btnchecklist;

	// Use this for initialization
	void Start () {




		btninfo.SetActive (false);

	}




	
	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt ("info") > 0) {

			Vector3 pos = btnchecklist.transform.position;

			//pos.x = 400f;

			btnchecklist.transform.position = pos;

			btninfo.SetActive (true);
		

		
		
		
		} else {

			Vector3 pos = btnchecklist.transform.position;

			//pos.x = 550f;

			btnchecklist.transform.position = pos;

		
			btninfo.SetActive (false);
		}
			
		}




		


	public void Mandarinformacion() 
	{


		if (PlayerPrefs.GetInt ("info") == 1) {

			SceneManager.LoadScene ("InfoVorticella");

		}

		if (PlayerPrefs.GetInt ("info") == 2) {

			SceneManager.LoadScene ("infoEuglema");

		}

		if (PlayerPrefs.GetInt ("info") == 3) {

			SceneManager.LoadScene ("InfoParamecium");

		}

		if (PlayerPrefs.GetInt ("info") == 4) {

			SceneManager.LoadScene ("InfoStentor");

		}

		if (PlayerPrefs.GetInt ("info") == 5) {

			SceneManager.LoadScene ("InfoCulpidium");

		}

		if (PlayerPrefs.GetInt ("info") == 6) {

			SceneManager.LoadScene ("InfoAmeba");

		}

		if (PlayerPrefs.GetInt ("info") == 7) {

			SceneManager.LoadScene ("InfoProtenos");

		}

		if (PlayerPrefs.GetInt ("info") == 8) {

			SceneManager.LoadScene ("InfoGiardia");

		}


	
		}
}

