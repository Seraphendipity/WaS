using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class PlayerRaycaster : MonoBehaviour
{
    GraphicRaycaster raycaster;
    PointerEventData pointerEventData;
    EventSystem eventSystem;
    // Start is called before the first frame update
    void Start()
    {
        // Get raycaster from gameobject, the canvas        
        raycaster = GetComponent<GraphicRaycaster>();
        // get event system from scene
        eventSystem = GetComponent<EventSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Using Primary Graphic Raycaster");
            pointerEventData = new PointerEventData(eventSystem);
            pointerEventData.position = Input.mousePosition;
            List<RaycastResult> results = new List<RaycastResult>();
        }

        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Using Primary Graphic Raycaster");
            pointerEventData = new PointerEventData(eventSystem);
            pointerEventData.position = Input.mousePosition;
            List<RaycastResult> results = new List<RaycastResult>();
            raycaster.Raycast(pointerEventData, results);

            foreach (RaycastResult result in results) {

                Debug.Log("Primary UI Hit: " + result);
                Debug.Log("Attempting SendMessage(onPrimary)");
                if (result.gameObject.GetComponent<ItemUI>() != null)
                {
                    result.gameObject.SendMessage("onPrimary");
                }
            }
        }
    }
}
