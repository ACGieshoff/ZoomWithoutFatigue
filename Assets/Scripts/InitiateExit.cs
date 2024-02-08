using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class InitiateExit : MonoBehaviour
{
    public GameObject[] gameObjects;
    public VideoPlayer vp;
    private bool exitOk = true;
    public GameObject exitMenu;

    // Start is called before the first frame update
   

    void Start()
    {
        exitMenu.SetActive(true);
        exitMenu.SetActive(false);

        //vp.loopPointReached += CheckVideo;

    }

    // Update is called once per frame
    void Update()
    {
        if (vp.isPlaying)
        {
            exitOk = false;
        }
        else
        {
            exitOk = true;
        }
     

    }

    /*void CheckVideo(UnityEngine.Video.VideoPlayer vp)
    {
        //check if video has reached the end
        // but that doesn't work anymore if you start playing it again...
        Debug.Log("Exit ok, video over.");
        exitOk = true;

    }*/
    public void exitApp()
    {
        //exit can only be initiated if the video has finished playing
        if (exitOk)
        {
            //confirm Exit menu pops up
            exitMenu.SetActive(true);

            //setActive(false) causes gameobjects to disappear entirely
            //Instead, we might want to deactivate the components in the menu only...
            //too much work

            foreach (GameObject go in gameObjects)
            {
                go.SetActive(false);
           
            }
            Debug.Log("exiting initiated");
          
        }
        else
        {
            Debug.Log("No, no, you can't exit now.");
        }
        

    }
}
