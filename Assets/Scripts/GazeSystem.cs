// Reticle: create sphere, put it under Camera, starting place: 0, 0, 0
// right click in Asset, create material, in material options: shader> google VR reticle shader
// create script GazeSystem, goes on Camera
// gazeableObjects need a collider!

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class GazeSystem : MonoBehaviour
{
    //public GameObject reticle;
  
    //public Color inactiveReticleColor = Color.gray;
    //public Color activeReticleColor = Color.blue;

    private GazeableObject currentGazeObject;
    private GazeableObject currentSelectedObject;

    private RaycastHit lastHit;


    void Start()
    {
        //SetReticleColor(inactiveReticleColor);

    }
    void Update()
    {
        ProcessGaze();
       

    }

    public void ProcessGaze()
    {
        // creates raycast, a stright line from the camera view
        Ray raycastRay = new Ray(transform.position, transform.forward);
        // return info whether we hit something
        RaycastHit hitInfo;

        Debug.DrawRay(raycastRay.origin, raycastRay.direction * 100);
        // if we hit something, do something
        if (Physics.Raycast(raycastRay, out hitInfo))
        {

            // Check if object interactable
            // what gameObject did we hit?
            GameObject hitObj = hitInfo.collider.gameObject;
            // Is it a GazeableObject (does it have the component/script GazeableObject)
            GazeableObject gazeObj = hitObj.GetComponentInParent<GazeableObject>();
     
            // if it has the GazeableObject Script on it
            if (gazeObj != null)
            {
                // and it is not the curentGazeObject, it means we lok at it for the first time
                if (gazeObj != currentGazeObject)
                {
                    // we nned to redefine  currentGazeObject
                    ClearCurrentObject();
                    currentGazeObject = gazeObj;
                    // call OnGazeEnter which does what ever we want to do when we look at stuff for the first time
                    currentGazeObject.OnGazeEnter(hitInfo);
                    // at least change teh reticle color
                    //SetReticleColor(activeReticleColor);
                    
                }

                // if we are already looking at it
                else
                {
                    // we call OnGaze and do, what ever onGaze does
                    currentGazeObject.OnGaze(hitInfo);

                }
            }
            // if it is not a GazeableObject (so it doesn't have the script), we are not interested in it
            else
            {
                ClearCurrentObject();
            }

        }
        // if we are not looking at something, we are not interested 
        else
        {
            ClearCurrentObject();
        }
    }

    //private void SetReticleColor(Color reticleColor)
    //{
        
        //reticle.GetComponent<Renderer>().material.SetColor("_Color", reticleColor);

    //}


    private void ClearCurrentObject()
    {
        // make sure we look at something
        if (currentGazeObject != null)
        {
            // when we look away change color to inactive state
            currentGazeObject.OnGazeExit();
            //SetReticleColor(inactiveReticleColor);
            // clear the current GazeObject
            currentGazeObject = null;
        }
    }

}