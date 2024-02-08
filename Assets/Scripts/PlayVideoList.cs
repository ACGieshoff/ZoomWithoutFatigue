using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideoList : MonoBehaviour
{
    // list of videos attached to one videoPlayer
    public VideoClip[] videoClips;
    // private fields are still editable
    private VideoPlayer videoplayer;
    // define how many videos you want to play
    private int videoClipIndex;
    // define the frame that should be shown
    public int frameToShow;
    private long frameCount;
    private long currentFrame;

    // Start is called before the first frame update
    private void Awake()
    {
        videoplayer = GetComponent<VideoPlayer>();
    }

    void Start()
    {
        // tell unity where to start
        videoplayer.clip = videoClips[0];     
    }


    public void playNext()
    {
        // moves on to the next clip in the index
        videoClipIndex++;
        if(videoClipIndex >= videoClips.Length)
        {
            videoClipIndex = videoClipIndex % videoClips.Length;
        }
        videoplayer.clip = videoClips[videoClipIndex];
    }

    public void videoStart()
    {
        videoplayer.Prepare();
        
        // plays any video
        videoplayer.frame = 0;
        videoplayer.Play();
        Debug.Log("videoplayer: video started");
    }

    

    public void videoStop()
    {
        // stops any video
        videoplayer.Stop();

    }

    public void selectTraining()
    {
        // set index to intro video
        videoClipIndex = 0;
        long frameCount = Convert.ToInt64(videoplayer.GetComponent<VideoPlayer>().frameCount) - 1;
        // Debug.Log("frame count: " + frameCount);
        videoplayer.clip = videoClips[videoClipIndex];

    }

    public void selectIntroA()
    {
        // set index to intro video
        videoClipIndex = 1;
        long frameCount = Convert.ToInt64(videoplayer.GetComponent<VideoPlayer>().frameCount)-1;
        // Debug.Log("frame count: " + frameCount);
        videoplayer.clip = videoClips[videoClipIndex];
        
    }

    public void selectIntroB()
    {
        // set index to intro video
        videoClipIndex = 2;
        long frameCount = Convert.ToInt64(videoplayer.GetComponent<VideoPlayer>().frameCount) - 1;
        // Debug.Log("frame count: " + frameCount);
        videoplayer.clip = videoClips[videoClipIndex];

    }

    public void selectVideoA()
    {
        // set index to video A
        videoClipIndex = 3;
        long frameCount = Convert.ToInt64(videoplayer.GetComponent<VideoPlayer>().frameCount);
        videoplayer.clip = videoClips[videoClipIndex];
        
    }

    public void selectVideoB()
    {
        // set index to video B
        videoClipIndex = 4;
        long frameCount = Convert.ToInt64(videoplayer.GetComponent<VideoPlayer>().frameCount);
        videoplayer.clip = videoClips[videoClipIndex];
        
    }

    public void showFirstFrame()
    {
        videoplayer.Prepare();
        // idea here: load first frame and stop immediately
        videoplayer.Pause();
        videoplayer.frame = frameToShow;
        
    }

}
