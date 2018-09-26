using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    void Awake()
    {
        
    }
    // Use this for initialization
    void Start () {
        //hidethemenu();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HideTheFirstMenu()
    {
        //Debug.Log("The HideTheFirstMenu is Invoked");
        gameObject.SetActive(false);
    }

    public void showthmenu()
    {
        gameObject.SetActive(true);
    }

    public void delayshowthemenu()
    {

        print(Time.time);
        Invoke("showthmenu", 1);
        print(Time.time);


        Debug.Log("invokeTest");



    }

}
