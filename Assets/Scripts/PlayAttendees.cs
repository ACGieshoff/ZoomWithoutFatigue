using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayAttendees : MonoBehaviour
{
    public VideoClip videoClip;    // Video clip to play

    public double[] duration;
    private VideoPlayer videoplayer;

    private int durationIndex;
    public int frameToShow;

    private void Awake()
    {
        videoplayer = GetComponent<VideoPlayer>();
    }

    private void Start()
    {
        // Set the video clip
        videoplayer.clip = videoClip;

        // Set the loop point to the end of the clip
        videoplayer.isLooping = true;
        videoplayer.loopPointReached += OnLoopPointReached;

    }



    public void startAttendees()
    {
        videoplayer.frame = 0;
        // Start playing the video
        videoplayer.Play();
    }

    public void stopAttendees()
    {
  
        // Start playing the video
        videoplayer.Stop();
    }



    public void selectDurationTraining()
    {
        // set index
        durationIndex = 0;
        videoplayer.time = duration[durationIndex];

    }

    public void selectDurationIntroA()
    {
        // set index
        durationIndex = 1;
        videoplayer.time = duration[durationIndex];
    }

    public void selectDurationIntroB()
    {
        // set index
        durationIndex = 2;
        videoplayer.time = duration[durationIndex];
    }

    public void selectDurationVideoA()
    {
        // set index
        durationIndex = 3;
        videoplayer.time = duration[durationIndex];
    }

    public void selectDurationVideoB()
    {
        // set index
        durationIndex = 4;
        videoplayer.time = duration[durationIndex];
    }

    private void OnLoopPointReached(VideoPlayer source)
    {
        // Reset the video player to the default clip duration
        videoplayer.time = duration[durationIndex];
        // videoplayer.Play();
        videoplayer.Play();
    }

    public void showFirstFrameAttendees()
    {
        videoplayer.Prepare();
        // idea here: load first frame and stop immediately
        videoplayer.Pause();
        videoplayer.frame = frameToShow;

    }
}
