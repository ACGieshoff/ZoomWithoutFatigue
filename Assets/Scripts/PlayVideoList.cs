using System.Collections;
using System.Collections.Generic;
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

    // Update is called once per frame
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
      
        
    }

    public void videoStop()
    {
        // stops any video
        videoplayer.Stop();
    }

    public void selectIntro()
    {
        // set index to intro video
        videoClipIndex = 0;

        videoplayer.clip = videoClips[videoClipIndex];
    }

    public void selectVideoA()
    {
        // set index to video A
        videoClipIndex = 1;
      
        videoplayer.clip = videoClips[videoClipIndex];
    }

    public void selectVideoB()
    {
        // set index to video B
        videoClipIndex = 2;

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
