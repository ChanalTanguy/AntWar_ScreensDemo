using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideButtons : MonoBehaviour {

    public GameObject[] ButtonList;
    public bool goRight;

	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<Button>().onClick.AddListener(NextSlide);
    }

    // Update is called once per frame
    void Update () {
		
	}
    void NextSlide()
    {
        if (!(!goRight && ButtonList[0].GetComponent<RectTransform>().anchoredPosition.x >= -311f)
            && !(goRight && ButtonList[ButtonList.Length-1].GetComponent<RectTransform>().anchoredPosition.x <= 311f))
        {

            foreach (GameObject b in ButtonList)
            {
                if (goRight)
                {
                    b.GetComponent<RectTransform>().anchoredPosition -= new Vector2(930f, 0f);
                }
                else
                {
                    b.GetComponent<RectTransform>().anchoredPosition += new Vector2(930f, 0f);
                }
                float posX = b.GetComponent<RectTransform>().anchoredPosition.x;

                if (posX < -311f || posX > 311f)
                {
                    b.SetActive(false);
                }
                else
                {
                    b.SetActive(true);
                }
            }
        }
    }
}
