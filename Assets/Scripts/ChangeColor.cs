using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour {

    public Color tint;

    public float add = 0f;
    public float dir = 1f;

    // Use this for initialization
    void Start () {
        StartCoroutine(ColorChange());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator ColorChange()
    {
        
        while (true)
        {
            this.gameObject.GetComponent<Image>().color = new Color(tint.r + add, tint.g + add, tint.b + add);
            if(add > 0.2f || add < -0.2f)
            {
                dir = dir * -1.0f;
            }
            add += 0.002f * dir;
            yield return true;
        }
    }
}
