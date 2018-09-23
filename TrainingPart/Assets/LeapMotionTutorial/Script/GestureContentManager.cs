using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureContentManager : MonoBehaviour
{
    private Dictionary<int, GameObject> SelectDictionary = new Dictionary<int, GameObject>();

    public int m_currentIndex = 0;

    //public GameObject GrabPanel_0;
    public GameObject GrabPanel_1;
    public GameObject EnlargePanel_2;
    public GameObject ShrinkPanel_3;
    public GameObject RotatePanel_4;
    public GameObject ViewPanel_5;
    public GameObject ClosePanel_6;
    public GameObject ColorPanel_7;
    public GameObject SizePanel_8;
    public GameObject CollectPanel_9;
    public GameObject BoxPanel_10;

    // Use this for initialization
    void Start()
    {
        SelectDictionary.Add(1, GrabPanel_1);
        SelectDictionary.Add(2, EnlargePanel_2);
        SelectDictionary.Add(3, ShrinkPanel_3);
        SelectDictionary.Add(4, RotatePanel_4);
        SelectDictionary.Add(5, ViewPanel_5);
        SelectDictionary.Add(6, ClosePanel_6);
        SelectDictionary.Add(7, ColorPanel_7);
        SelectDictionary.Add(8, SizePanel_8);
        SelectDictionary.Add(9, CollectPanel_9);
        SelectDictionary.Add(10, BoxPanel_10);
        //GrabPanel_1.SetActive(false);

      //  SelectDictionary.Add(10, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void JumpToPlane(int index)
    {
        SelectDictionary[m_currentIndex].SetActive(false);
        SelectDictionary[index].SetActive(true);
        m_currentIndex = index;
    }



}
