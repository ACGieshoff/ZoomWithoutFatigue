using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonDetector : MonoBehaviour
{
    public void getButtonName()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;
    }
    

}
