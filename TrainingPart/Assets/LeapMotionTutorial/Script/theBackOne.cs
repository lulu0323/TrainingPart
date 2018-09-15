using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//开始状态 当前的板子存在
//隐藏当前的板子
public class theBackOne : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void hidethemenu()
    {
        gameObject.SetActive(false);
    }

    public void showthmenu()
    {
        gameObject.SetActive(true);
    }

}
