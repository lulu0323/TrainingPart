using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//开始状态：板子被隐藏
//隐藏板子
public class theNextOne : MonoBehaviour {

	// Use this for initialization
	void Start () {
        hidethemenu();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void showthmenu()
    {
        gameObject.SetActive(true);
    }
    public void hidethemenu()
    {
        gameObject.SetActive(false);
    }
}
