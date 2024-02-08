using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
//using UnityEngine.Video;

// this goes on every (interactable) object
// new strategy: have a child-object that changes the color(class BabyGazeable)
// record everything with button
 
public class GazeableObject : MonoBehaviour
{
   
    //define the colors for eyetracking
    public Color inactiveColor = new Color(0.3f, 0.4f, 0.6f);
    public Color activeColor = new Color(0.1f, 0.8f, 0.6f);



    // add Start
    void Start()
    {
        

    }

    // better not have nything useless in update
    void Update()
    {


    }

    // collect infor for gaze enter
    public virtual void OnGazeEnter(RaycastHit hitInfo)
    {

        
        // Debug.Log("Gaze entered on" + gameObject.name + " " + Time.time);

        // Try to draw a box. The idea is to attach a child object to the quad taht is just slightly larger, and change its color
        // the problem is: it changes the color for all (!) children (so the video turns blue)

        GameObject baby = transform.Find("baby").gameObject;
        //baby.GetComponent<Renderer>().material.color = Color.activeColor;
        baby.GetComponent<Renderer>().material.SetColor("_Color", activeColor);

       

    }

    public virtual void OnGaze(RaycastHit hitInfo)
    {
        Debug.Log("Gaze hold on" + gameObject.name);
    }

    // collect info for gaze exist
    public virtual void OnGazeExit()
    {
       
        GameObject baby = transform.Find("baby").gameObject;
        //baby.GetComponent<Renderer>().material.color = Color.inactiveColor;
        baby.GetComponent<Renderer>().material.SetColor("_Color", inactiveColor);
        //Debug.Log("Gaze exited on" + gameObject.name);
     
        

    }

}