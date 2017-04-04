using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public GameObject info;

	// Use this for initialization
	void Start () {
		
		iTween.FadeTo(info, 0.0f, 0.0f);
		//print ("1");
	}

	void OnTriggerEnter(Collider other) {

		//info.SetActive(true);
		iTween.FadeTo(info, 0.6f, 0.5f);
		//print ("2");

	}

	void OnTriggerExit(Collider other) {

		//info.SetActive(false);
		iTween.FadeTo(info, 0.0f, 0.5f);
	}


	
	// Update is called once per frame
	void Update () {



	}
}
