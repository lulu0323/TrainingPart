using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlay : MonoBehaviour {
    //public static AudioPlay Instance;
    public VideoClip[] MyVideo;
    //public AudioSource FCAudio;
    // public AudioSource BabyAudio;
    // Use this for initialization
    void Awake()
    {
        //Instance = this;
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    /// <summary>
    /// 播放某个音频
    /// </summary>
    /// <param name="i"></param>
    public void playVideo(int i)
    {
        MyVideo.clip = MyVideo[i];
        MyVideo.Play();
    }
    /// <summary>
    /// 停止播放所有的音频
    /// </summary>
    //public void StopplayAll()
    //{

    //    for (int i = 0; i < FuChuAudio.Length; i++)
    //    {
    //        FCAudio.clip = FuChuAudio[i];
    //        FCAudio.Stop();
    //    }
    //}
    ///// <summary>
    ///// 停止播放某个音频
    ///// </summary>
    ///// <param name="i"></param>
    //public void StopplayOne(int i)
    //{
    //    FCAudio.clip = FuChuAudio[i];
    //    FCAudio.Stop();
    //}

    ///// <summary>
    ///// 循环播放某个音频
    ///// </summary>
    ///// <param name="i"></param>
    //public void playLoop(int i)
    //{
    //    FCAudio.clip = FuChuAudio[i];
    //    FCAudio.loop = true;//设置声音为循环播放 ;
    //    FCAudio.Play();
    //}
}

