using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidePanels : MonoBehaviour {

    public GameObject PanelToShow;
    public GameObject[] PanelsToHide;

    // Use this for initialization
    void Start()
    {
        this.gameObject.GetComponent<Button>().onClick.AddListener(HideAll);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void HideAll()
    {
        foreach (GameObject p in PanelsToHide)
        {
            p.SetActive(false);
        }
        PanelToShow.SetActive(true);
    }
}
