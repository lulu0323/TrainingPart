using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplanationMenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        HideThisMenu();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //隐藏当前的板子
    public void HideThisMenu()
    {
        gameObject.SetActive(false);
    }

    public void ShowNextMenu()
    {
        gameObject.SetActive(true);
    }

}
