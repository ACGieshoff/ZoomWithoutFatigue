using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Again, the idea here is to change the material of a gameObject after a certain time.
// This is the second approach to solve this problem (which shouldn't be one)
// The idea is to use coroutines
// inspiration:  https://answers.unity.com/questions/866703/how-to-make-an-object-change-material-after-a-time.html


public class changeMaterial : MonoBehaviour
{
    //Let's say myObject is my object.
    GameObject myObject;

    bool shouldChange = false;

    // slides are actually materials. [] apparently creates a list 
    // public because it's practical to simply change slides, number of slides and display via the editor
    public Material[] slide;

    // number of slides
    public int x;

    // this one doesn't need to be public. It'simply something like a stopwatch
    private float indicatorStartTime;

    // define a number of timepoints or rather durations when the slide is supposed to change
    // it's public because it's convenient to change it via the editor (public displays those fields in the editor, private doesn't)
    public float[] timeToChange;

    // Start is called before the first frame update
    void Start()
    {
        // tell unity to start with the first slide
        x = 0;
        // not sure this makes sense. Shoud rather be in Update
        indicatorStartTime = 0;

    }

    // Update is called once per frame
    void Update()
    {
        // update timer... but I feel there is no need for this because of the coroutine.
        indicatorStartTime = Time.time + timeToChange[x];

        // this basically starts the coroutine immediately.
        // Any timing-issues should then be handeld in the coroutine
        if (shouldChange = false && indicatorStartTime <= Time.time)
        {
            shouldChange = true;
            StartCoroutine(materialChangeIndicator());
        }
    }

    // simply to have a method to drag an the gameObject.
    public void StartChangingSlides()
    {
        StartCoroutine(materialChangeIndicator());
    }

    // This is the coroutine
    private IEnumerator materialChangeIndicator()

    {
        // as long as the condition is true (which it is basically on start)
        while (shouldChange)
        {
            //Let's check whether it really started...
            Debug.Log("Start coroutine");
            // get the current Material of the gameObject
            Material originalMaterial = myObject.GetComponent<Renderer>().material;
            // and change it to the material of slide number x
            // When the coroutine starts the first time, there should be no change since x is still 0
            myObject.GetComponent<Renderer>().material = slide[x];

            // define the "waiting time" until the next slide
            // this is simply number x of the timeToChange
            float seconds = timeToChange[x];
            Debug.Log("Time to new slide is:" + seconds);

            // wait some time
            yield return new WaitForSeconds(seconds);
            // move to next slide after the time has elapsed
            x = x + 1;
            // and start the coroutine all over again
            StartCoroutine(materialChangeIndicator());
        }

    }
}

