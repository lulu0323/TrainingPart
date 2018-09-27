using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryOn : MonoBehaviour {

    private Vector3 pointZero;
    private Vector3 pointCart;
    private Vector3 pointMove;
    public GameObject Cart;
   // public GameObject c1;
    public GameObject c1;
    public Vector3 a;
    public Vector3 startPos;

    //public AudioClip clip;


    void Start()
    {
        pointZero = transform.position;
    }

    public void Update()
    {
        pointMove = gameObject.transform.position;           //实时获取物体的位置
        pointCart = Cart.GetComponent<Transform>().position; //实时获取购物车的位置


        if (Vector3.Distance(transform.position, pointCart) < 0.1)
        {
            c1.SetActive(false);                                    //销毁物体
            //AudioSource.PlayClipAtPoint(clip, transform.position);   //音效
        }
    }
    public void showthecube()
    {
        c1.SetActive(true);
        c1.transform.position = a;
        c1.transform.rotation = Quaternion.identity;
        c1.transform.localScale = startPos;
    }
    public void delayshowthecube()
    {

        //print(Time.time);
        Invoke("showthecube", 2);
        //print(Time.time);


        //Debug.Log("invokeTest");



    }
}
