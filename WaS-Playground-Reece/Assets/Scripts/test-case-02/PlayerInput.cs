using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 3D Display Select
        // Physics.Raycast
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Player Clicked M0");
            DisplaySelect();

        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Player Clicked M2");
            DisplayInteract();
        }

        // 2D Display Select
        // Graphics.Raycast
    }
    void DisplayInteract()
    {
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        if (hit) {
            //if (hitInfo.transform.GetComponent<ISelectable>() != null) {
            if (hitInfo.transform.GetComponent<IInteractable>() != null) {
                // FIXME: check if object is owned by player
                hitInfo.transform.GetComponent<IInteractable>().Interact();
            }
                //Debug.Log("You clicked a selectable 3D Object");
                //Debug.Log("Getting SelectData...");
                //Debug.Log("contextInfo: " + hitInfo.transform.GetComponent<ISelectable>().Select().contextInfo);
                //Debug.Log("CUSTOMCONTEXTINFO: " + hitInfo.transform.GetComponent<ISelectable>().Select().customContextInfo);
        }

    }

    void DisplaySelect()
    {
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        if (hit) {
            //if (hitInfo.transform.GetComponent<ISelectable>() != null) {
            if (hitInfo.transform.GetComponent<ISelectable>() != null) {
            }
                //Debug.Log("You clicked a selectable 3D Object");
                //Debug.Log("Getting SelectData...");
                //Debug.Log("contextInfo: " + hitInfo.transform.GetComponent<ISelectable>().Select().contextInfo);
                //Debug.Log("CUSTOMCONTEXTINFO: " + hitInfo.transform.GetComponent<ISelectable>().Select().customContextInfo);
        }
    }
}
