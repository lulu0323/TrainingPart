using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMenu2 : MonoBehaviour {

	// Use this for initialization
	


    void Awake()
    {

    }
    // Use this for initialization
    void Start()
    {
        hidethemenu();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void hidethemenu()
    {
        gameObject.SetActive(false);
    }

}


