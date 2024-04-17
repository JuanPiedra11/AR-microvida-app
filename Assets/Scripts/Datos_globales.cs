using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datos_globales : MonoBehaviour {

	// Use this for initialization
	void Start () {

	


		PlayerPrefs.SetInt("info", 0);
		int info = PlayerPrefs.GetInt ("info", 0);	


		PlayerPrefs.SetInt("checkvorticela", 0);
		int checkvorticela = PlayerPrefs.GetInt ("checkvorticela", 0);
		//print (checkvorticela);

		PlayerPrefs.SetInt("checkproteros", 0);
		int checkproteros = PlayerPrefs.GetInt ("checkproteros", 0);
	

		PlayerPrefs.SetInt("checkameba", 0);
		int checkameba = PlayerPrefs.GetInt ("checkameba", 0);
	
		PlayerPrefs.SetInt("checkstentor", 0);
		int checkstentor = PlayerPrefs.GetInt ("checkstentor", 0);

		PlayerPrefs.SetInt("checkcolpidium", 0);
		int checkcolpidium = PlayerPrefs.GetInt ("checkcolpidium", 0);	
	
		PlayerPrefs.SetInt("checkgiardia", 0);
		int checkgiardia = PlayerPrefs.GetInt ("checkgiardia", 0);

		PlayerPrefs.SetInt("checkeuglena", 0);
		int checkeuglena = PlayerPrefs.GetInt ("checkeuglena", 0);	

		PlayerPrefs.SetInt("checkparamecium", 0);
		int checkparamecium = PlayerPrefs.GetInt ("checkparamecium", 0);



	
	
	
	}


	
	// Update is called once per frame
	void Update () {




		
	}
}
