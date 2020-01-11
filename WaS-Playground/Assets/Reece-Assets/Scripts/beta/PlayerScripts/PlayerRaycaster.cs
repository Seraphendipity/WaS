using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycaster : MonoBehaviour
{
    public Player player;

    public PlayerRaycaster(Player player)
    {
        this.player = player; 
    }
    /// <summary>
    /// Sends the message "LeftClick()" to the hit GameObject.
    /// </summary>
    public virtual void LeftClick()
    {
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
        GameObject hitObject = hitInfo.transform.gameObject;

        // Check if the object may be interacted with
        if (IsInteractable(hitObject))
        {
            hitObject.SendMessage("LeftClick");
        }

    }

    /// <summary>
    /// Sends the message "RightClick()" to the hit GameObject.
    /// </summary>
    public virtual void RightClick()
    {
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
        GameObject hitObject = hitInfo.transform.gameObject;

        if (IsInteractable(hitObject))
        {
            hitObject.SendMessage("RightClick");
        }

    }

    public virtual void Command(string functionName)
    {

    }

    public bool IsInteractable(GameObject gameObject)
    {
        bool isInteractable = false; // Assume the object is not interactable
        if (gameObject.GetComponent<Interactable>() != null) {
            isInteractable = true;
            Debug.Log("PlayerRaycaster.isInteractable: " + gameObject.name + " TRUE");
        } else {
            Debug.Log("PlayerRaycaster.isInteractable: " + gameObject.name + " FALSE");
        }

        return isInteractable;
    }
}