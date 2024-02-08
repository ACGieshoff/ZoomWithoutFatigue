using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApp : MonoBehaviour
{
    public GameObject[] gameObjects;
    public GameObject exitMenu;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in gameObjects)
        {
            go.SetActive(true);
            //Destroy(go);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void confirmExit()
    {
        foreach (GameObject go in gameObjects)
        {
            go.SetActive(false);
            //Destroy(go);
        }
        exitMenu.SetActive(false);
        //Destroy(exitMenu);
        Debug.Log("All halluciniations gone. You're alone in the world.");
        Application.Quit();
        Debug.Log("roger and over");

    }

    public void cancelExit()
    {
        exitMenu.SetActive(false);
        foreach (GameObject go in gameObjects)
        {
            go.SetActive(true);
            
        }
        
        Debug.Log("back to normal");

    }
}
