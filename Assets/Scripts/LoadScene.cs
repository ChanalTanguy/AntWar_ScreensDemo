using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour {

    public string scene;

	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<Button>().onClick.AddListener(LoadNextScene);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void LoadNextScene()
    {
        SceneManager.LoadScene(scene);
    }
}
