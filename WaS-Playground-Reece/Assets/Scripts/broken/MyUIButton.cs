using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MyUIButton : MonoBehaviour
{
    public int testVar = 7;
 
    void OnMouseDown()
    {
        Debug.Log("touch detected ");
 
        EventManager.TriggerEvent("testEvent", this.gameObject);
    }
 
}