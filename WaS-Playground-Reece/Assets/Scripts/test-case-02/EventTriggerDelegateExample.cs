using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventTriggerDelegateExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        EventTrigger trigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((data) => {
            OnPointerDownDelegate((PointerEventData)data); 
        });
        trigger.triggers.Add(entry);
    }

    private void OnPointerDownDelegate(PointerEventData data)
    {
        Debug.Log("OnPointerDownDelegate called.");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
