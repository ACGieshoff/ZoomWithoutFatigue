using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using Microsoft.MixedReality.Toolkit.Utilities;

public class GestureToggle : MonoBehaviour
{
    //public GameObject gameObject;
    public GameObject[] gameObjects;
    private Component stateGesture;
    private Component stateBounds;
    //private RotationAxisConstraint rotationConstraint;
    //private ConstraintManager manager;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleGesture()
    {
        foreach(GameObject go in gameObjects)
        {
            stateGesture = go.GetComponent<ObjectManipulator>();
            stateBounds = go.GetComponent<BoundsControl>();
            
            if (stateGesture != null)
            {
                
                Destroy(stateGesture);
                Destroy(stateBounds);
              
                Debug.Log(go.name + "control turned off");

            }
            else
            {
                
                go.AddComponent<ObjectManipulator>();
                go.AddComponent<BoundsControl>();
                Debug.Log(go.name + "control turned on");
                //rotationConstraint = go.AddComponent<RotationAxisConstraint>();
                //Debug.Log("got rotationConstraint");
                //rotationConstraint.ConstraintOnRotation = AxisFlags.YAxis;
                //rotationConstraint.ConstraintOnRotation = AxisFlags.XAxis;
                //rotationConstraint.ConstraintOnRotation = AxisFlags.ZAxis;
                //manager = GetComponent<ConstraintManager>();
                //Debug.Log("got manager");
                //manager.AutoConstraintSelection = false;
                //manager.AddConstraintToManualSelection(rotationConstraint);
            }
        }
        
    }

    public void toogleOn()
    {
        foreach (GameObject go in gameObjects)
        {
            stateGesture = go.GetComponent<ObjectManipulator>();
            stateBounds = go.GetComponent<BoundsControl>();
            if (stateGesture == null)
            {

                go.AddComponent<ObjectManipulator>();
                go.AddComponent<BoundsControl>();
                Debug.Log(go.name + "control turned on");
                //rotationConstraint = go.AddComponent<RotationAxisConstraint>();
                //rotationConstraint.ConstraintOnRotation = AxisFlags.YAxis;
                //rotationConstraint.ConstraintOnRotation = AxisFlags.XAxis;
                //rotationConstraint.ConstraintOnRotation = AxisFlags.ZAxis;
                //manager = GetComponent<ConstraintManager>();
                //manager.AutoConstraintSelection = false;
                //manager.AddConstraintToManualSelection(rotationConstraint);

            }
            
        }

    }

    public void toogleOff()
    {
        foreach (GameObject go in gameObjects)
        {
            stateGesture = go.GetComponent<ObjectManipulator>();
            stateBounds = go.GetComponent<BoundsControl>();
           

            if (stateGesture != null)
            {

                Destroy(stateGesture);
                Destroy(stateBounds);
               
                Debug.Log(go.name + "control turned off");

            }

        }

    }
}
