using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenu : MonoBehaviour {
    private AsyncOperation scene;
	// Use this for initialization
	void Start () {
        scene = SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
        scene.allowSceneActivation = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Escape)){
           
            scene.allowSceneActivation = true;
        }
	}
}
