using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int currentIndex = 0;
    public float currentTimer = 0f;
    bool isTimer = false;

    private Dictionary<int, float> timerDictionary = new Dictionary<int, float>();
    //private Dictionary<int,string> nameDictionary = new Dictionary<int, string> ();



    //public Text ShowTime;//显示计时器时间
    /*
    public float t0;
    public float t1;
    public float t2;
    public float t3;
    public float t4;
    public float t5;
    public float t6;
    public float t7;
    public float t8;
    public float t9;
 */

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
            Debug.Log("Timer Stop!");
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

    public void OnApplicationQuit()

    {
        Debug.Log("This is the end of game!");
        foreach (var item in timerDictionary)
        {
            Debug.Log("This is the " + item.Key + "Plane");
            Debug.Log("and the Time count is" + item.Value + "s.");
        }

    }

}
