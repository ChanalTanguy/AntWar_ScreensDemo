using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DisplayBorder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowBorder()
    {
        this.gameObject.transform.Find("Border").gameObject.GetComponent<Image>().enabled = true;
    }

    public void HideBorder()
    {
        this.gameObject.transform.Find("Border").gameObject.GetComponent<Image>().enabled = false;
    }
}
