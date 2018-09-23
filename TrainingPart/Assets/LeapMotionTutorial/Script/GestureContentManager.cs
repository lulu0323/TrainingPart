using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureContentManager : MonoBehaviour
{
    private Dictionary<int, GameObject> SelectDictionary = new Dictionary<int, GameObject>();

    public int m_currentIndex = 0;

    //public Gameobject GrabPanel_0;
    public GameObject GrabPanel_1;
    //public Gameobject EnlargePanel_2;
    //public Gameobject ShrinkPanel_3;
    //public Gameobject RotatePanel_4;
    //public Gameobject ViewPanel_5;
    //public Gameobject ClosePanel_6;
    //public Gameobject ColorPanel_7;
    //public Gameobject SizePanel_8;
    //public Gameobject CollectPanel_9;
    //public Gameobject BoxPanel_10;

    // Use this for initialization
    void Start()
    {
        SelectDictionary.Add(0, GrabPanel_1);
        //timerDictionary.Add(1, EnlargePanel_2);
        //timerDictionary.Add(2, ShrinkPanel_3);
        //timerDictionary.Add(3, RotatePanel_4);
        //timerDictionary.Add(4, ViewPanel_5);
        //timerDictionary.Add(5, ClosePanel_6);
        //timerDictionary.Add(6, ColorPanel_7);
        //timerDictionary.Add(7, SizePanel_8);
        //timerDictionary.Add(8, CollectPanel_9);
        //timerDictionary.Add(9, BoxPanel_10);
        GrabPanel_1.SetActive(false);

      //  timerDictionary.Add(10, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void JumpToPlane(int index)
    {
        SelectDictionary[m_currentIndex].Setactive(false);
        SelectDictionary[index].Setactive(true);
        m_currentIndex = index;
    }



}
