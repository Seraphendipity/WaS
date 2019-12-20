using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 
/// </summary>
[System.Serializable]
public class PlayerInputEvent : UnityEvent<PlayerInputManager> {}

[System.Serializable]
public class PlayerInteractEvent : UnityEvent<Interactable> {}

public class PlayerInputManager : MonoBehaviour
{
    public Player player;
    public Transform selectedEntity;
    #region PlayerInputEvents

    public PlayerInputEvent onPrimaryInput;
    public PlayerInputEvent onSecondaryInput;
    public PlayerInteractEvent onInteractInput;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        if (player != null)
        {
            Debug.Log("PlayerInputManager: Initialzed with Player " + player.playerName);
        } 

        else
        {
            Debug.LogError("PlayerInputManager: There needs to be a Player object referenced by this Component.");
            // TODO: throw an error, prevent game start?
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onPrimaryInput.Invoke(this);
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit && isSelectable(hitInfo))
            {
                Debug.Log("PlayerSelectionManager.PrimaryRayCaster(): Hit a selectable object " + hitInfo.transform.name);
                selectedEntity = hitInfo.transform;
            }

            else
            {
                selectedEntity = null;
            }

        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("PlayerInputManager: " + player.playerName + " INPUT MouseButtonDown(1) ");
            Interact();
            onSecondaryInput.Invoke(this);
        }
    }

    private bool isSelectable(RaycastHit hitInfo)
    {
        if (hitInfo.transform.GetComponent<ISelectable>() != null)
        {
            Debug.Log("PlayerSelectionManager.isSelectable(): TRUE|" + hitInfo.transform.name);
            return true;
        }

        else
        {
            Debug.Log("PlayerSelectionManager.isSelectable(): FALSE|" + hitInfo.transform.name);
            return false;
        }
    }

    #region PlayerInputEvent responder

    public void Interact()
    {
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
        if (hit && isInteractable(hitInfo))
        {
            Transform interactWith = hitInfo.transform;
            if (selectedEntity.GetComponent<ICommandable>() != null)
            {
                selectedEntity.GetComponent<ICommandable>().Command(interactWith.GetComponent<Interactable>());
                Debug.Log(selectedEntity.name + " is interacting with " + interactWith);
            }
        }
    }

    #endregion

    #region Helper Functions

    private bool isInteractable(RaycastHit hitInfo)
    {
        if (hitInfo.transform.GetComponent<Interactable>() != null)
        {
            Debug.Log("PlayerSelectionManager.isInteractable(): TRUE|" + hitInfo.transform.name);
            return true;
        }

        else
        {
            Debug.Log("PlayerSelectionManager.isInteractable(): FALSE|" + hitInfo.transform.name);
            return false;
        }
    }
    #endregion
}
