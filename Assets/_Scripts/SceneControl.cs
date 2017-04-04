using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public Button exit;
	public Button living;
	public Button dining;

    private AsyncOperation scene1;
	private AsyncOperation scene2;

    // Use this for initialization
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

		exit.onClick.AddListener(exitClicked);
        living.onClick.AddListener(livingClicked);
        dining.onClick.AddListener(diningClicked);
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void exitClicked()
    {
        Debug.Log("exit");

        Application.Quit();
        

    }

    void diningClicked()
    {
        Debug.Log("eat");

        scene2 = SceneManager.LoadSceneAsync("Second", LoadSceneMode.Single);
        scene2.allowSceneActivation = true;

    }

    void livingClicked()
    {
        Debug.Log("living");

        scene1 = SceneManager.LoadSceneAsync("First", LoadSceneMode.Single);
        scene1.allowSceneActivation = true;

    }
   
}
