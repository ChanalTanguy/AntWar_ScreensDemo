using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UncheckAll : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<Toggle>().onValueChanged.AddListener(GlobalUncheck);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void GlobalUncheck(bool b)
    {
        Toggle[] ToggleList = FindObjectsOfType<Toggle>();
        Debug.Log("START");
        foreach (Toggle t in ToggleList)
        {
                t.isOn = false;
        }
        if (b)
        {
            this.gameObject.GetComponent<Toggle>().onValueChanged.RemoveListener(GlobalUncheck);
            this.gameObject.GetComponent<Toggle>().isOn = true;
            this.gameObject.GetComponent<Toggle>().onValueChanged.AddListener(GlobalUncheck);
        }
        
    }
}
