using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerUIRaycaster : MonoBehaviour
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
        // Check if M1
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Using Graphic Raycaster");
            // Setup new pointer event
            pointerEventData = new PointerEventData(eventSystem);
            // Set pointer event pos to mouse pos
            pointerEventData.position = Input.mousePosition;

            // create list of raycast results
            List<RaycastResult> results = new List<RaycastResult>();

            raycaster.Raycast(pointerEventData, results);

            // raycast with graphic raycaster and mouse click position
            foreach (RaycastResult result in results)
            {
                Debug.Log("Hit " + result.gameObject.name);
                    Debug.Log("reslut ==" + result);
                    Debug.Log("result.gameObject ==" + result.gameObject);
                if (result.gameObject.name == "ItemUIPrefab(Clone)");
                {
                    Debug.Log("Hit an ItemUIPrefab(Clone)... sending onClick message");
                    result.gameObject.GetComponent<ItemUI>().gameObject.SendMessage("onClick"); // TODO: change this to watch for interface/interface name instead (sellable...);
                }
            }
        }
        
    }
}
