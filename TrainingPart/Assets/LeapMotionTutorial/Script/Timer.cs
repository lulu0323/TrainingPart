using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class TimerData
{
    public int playerNumber;
    public string playerName;

    public float timeEmpty_0;
    public float timeGrabPanel_1;
    public float timeEnlargePanel_2;
    public float timeShrinkPanel_3;
    public float timeRotatePanel_4;
    public float timeViewPanel_5;
    public float timeClosePanel_6;
    public float timeColorPanel_7;
    public float timeSizePanel_8;
    public float timeCollectPanel_9;
    public float timeBoxPanel_10;
}

public class Timer : MonoBehaviour
{
    private int currentIndex = 0;
    private float currentTimer = 0f;
    bool isTimer = false;

    private TimerData timerData = new TimerData();
    private Dictionary<int, float> timerDictionary = new Dictionary<int, float>();
    //private Dictionary<int,string> nameDictionary = new Dictionary<int, string> ();
    // Use this for initialization
    void Start()
    {
        timerDictionary.Add(0, 0f);
        timerDictionary.Add(1, 0f);
        timerDictionary.Add(2, 0f);
        timerDictionary.Add(3, 0f);
        timerDictionary.Add(4, 0f);
        timerDictionary.Add(5, 0f);
        timerDictionary.Add(6, 0f);
        timerDictionary.Add(7, 0f);
        timerDictionary.Add(8, 0f);
        timerDictionary.Add(9, 0f);
        timerDictionary.Add(10, 0f);


        EnterPlane(0);

        /*
		JsonObject jo = // ************************ /
		string textPath = jo.GetString ("TextPath"); 
		JsonObject testObj = jo.GetObj("testObj");
		JsonArray testArray = jo.GetArray("testArray");
		//------

		//EnCode
		JsonObject newObj = new JsonObject ();
		newObj.SetString("TextPath",str);
		testObj = new JsonObj();
		newObj.SetObj("testObj",testObj);
		newObj.SetArray("testArray",testArray);

		string bigObjStr = newObj.ToString();
		string path = "D:/test/bigObjStr.json";
		FileManager.SaveToString(path,bigObjStr);
		*/

        //NextPlane ();
        //ShowTime = GetComponent<Text>();//显示计时器时间
    }

    // Update is called once per frame
    void Update()
    {
        //currentTimer += Time.deltaTime;
        if (isTimer)
        {
            timerDictionary[currentIndex] += Time.deltaTime;

            //ShowTime.text = currentTimer.ToString("F2");//显示计时器时间

        }
    }

    public void EnterPlane(int index)
    {
        if (index < timerDictionary.Count && index >= 0)
        {
            isTimer = true;
            currentIndex = index;
        }
        else
        {
            isTimer = false;
        }
    }

    public void NextPlane()
    {
        EnterPlane(currentIndex + 1);
    }

    public void BackPlane()
    {
        EnterPlane(currentIndex - 1);
    }

    public void GetEachTime()
    {
        timerData.timeEmpty_0 = timerDictionary[0];
        timerData.timeGrabPanel_1 = timerDictionary[1];
        timerData.timeEnlargePanel_2 = timerDictionary[2];
        timerData.timeShrinkPanel_3 = timerDictionary[3];
        timerData.timeRotatePanel_4 = timerDictionary[4];
        timerData.timeViewPanel_5 = timerDictionary[5];
        timerData.timeClosePanel_6 = timerDictionary[6];
        timerData.timeColorPanel_7 = timerDictionary[7];
        timerData.timeSizePanel_8 = timerDictionary[8];
        timerData.timeCollectPanel_9 = timerDictionary[9];
        timerData.timeBoxPanel_10 = timerDictionary[10];

    }

    public void OnApplicationQuit()

    {
        Debug.Log("This is the end of game!");
        foreach (var item in timerDictionary)
        {
            Debug.Log("This is the " + item.Key + "Plane");
            Debug.Log("and the Time count is" + item.Value + "s.");
        }

        GetEachTime();
        string json = JsonUtility.ToJson(timerData);

    }

}
