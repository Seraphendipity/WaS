using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyUIButtonReciever : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        EventManager.StartListening("testEvent", testMethod);
    }
 
    private void OnDisable()
    {
        EventManager.StopListening("testEvent", testMethod);
    }
 
    void testMethod(GameObject go)
    {
        MyUIButton button = go.GetComponent<MyUIButton>();
 
        Debug.Log("test event system " + button.testVar);
    }
}
