using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// what this is supposed to do: Change the material of a GameObject after a given time has elapsed
// the timer should start when I click on the play button (starts speake video and presentation simultaneously)
public class ChangeSlide : MonoBehaviour
{
    // drag script on the Quad that is supposed to display the slides
    // define Renderer (though this may be simply Material?)

    Renderer myObject;

    // slides are actually materials. [] apparently creates a list of materials
    // public because it's practical to simply change slides in the editor
    public Material[] slide;

    // number of slides
    public int x;

    // this one doesn't need to be public. It'simply something like a stopwatch
    private float timer;

    // and these are the timepoints when the slide is supposed to change
    public float[] timesToChange;

    // This is simply to use a while-loop
    bool notTimeToChange = true;


    // Start is called before the first frame update.
    // It seems to called independently of whether I click on play or not
    // Maybe that's normal, maybe not.
    void Start()
    {
        // C# seems to start counting with 0. good to know.

        // tell unity where to start
        x = 0;
        // set timer to 0
        timer = 0;

        // get the current renderer 
        myObject = GetComponent<Renderer>();
        myObject.enabled = true;
        myObject.sharedMaterial = slide[x];

        Debug.Log("script changeSlide started");

    }

    // The stuff below apprently happens each time the screen is refreshed
    // What should happen?
    // the timer needs to be updated
    // and then, most of time nothing (unless it's time to change the slide, of course)
    void Update()
    {
        // update the timer before checking the condition. If I understand correctly, do will be executed as long as the condition is true
        do
        {
            // update timer
            timer += Time.deltaTime;
            // not a good idea to do that... but yes, the messagse popped up
            // Debug.Log("timer:" + timer);

        }
        while (notTimeToChange);


        // this works on click
        // myObject.sharedMaterial = slide[x];

    }

    // This is where things get interesting (and this was my first approach)
    public void slideChange()
    {

        // whenever timer reaches the point where it´s time to change the slide
        if (timer >= timesToChange[x])
        {
            // set bool to false (because it's time to change now)
            notTimeToChange = false;
            Debug.Log("time to change!");

            // it should increase the index by 1 (that is: move to the next slide and 1 timepoint)
            x = x + 1;
            // check whether it works ... no.
            Debug.Log("x is: " + x);

            // This is supposed to change the material on the gameObject. 
            myObject.sharedMaterial = slide[x];
            Debug.Log("timer after change " + timer);
            // Reset the timer to 0. This way, I don't need to measure to time point to change from the beginning but only from the last slide.
            timer = 0;
            // set boool to true
            notTimeToChange = true;

        }

    }
}


