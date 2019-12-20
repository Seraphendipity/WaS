using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerInputManager : MonoBehaviour
{
    public Player player;
    public Transform selectedEntity;
    public Inventory selectedEntityInventory;

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
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Button 0");
            selectedEntity = RaycastSelector();
            TryGetInventory();
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Mouse Button 1");
            Interact();
        }
    }

    public void Select()
    {
        Transform target = Raycast();
        if (target != null && isInteractable(target))
        {
            Debug.Log("Hit a selectable object " + target.name);
            this.selectedEntity = target;
        }

        else
        {
            this.selectedEntity = null;
        }
    }

    public void Interact()
    {
        Transform target = Raycast();
        if (target != null)
        {
            if (isInteractable(target) && isCommandable(selectedEntity))
            {
                selectedEntity.GetComponent<ICommandable>().Command(target.GetComponent<Interactable>());
            }
            else
            {
                Debug.Log("Cannot interact");
            }
        }
        else
        {
            Debug.Log("No interact target");
        }
    }

    #region Helper Functions

    private bool isInteractable(Transform target)
    {
        if (target.GetComponent<Interactable>() != null)
        {
            Debug.Log("PlayerSelectionManager.isInteractable(): TRUE|" + target.name);
            return true;
        }

        else
        {
            Debug.Log("PlayerSelectionManager.isInteractable(): FALSE|" + target.name);
            return false;
        }
    }

    public bool isCommandable(Transform target)
    {
        if (target.GetComponent<ICommandable>() != null)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
    public Transform Raycast()
    {
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        if (hit)
        {
            return hitInfo.transform.parent;
        }

        else
        {
            return null;
        }
    }

    public Transform RaycastSelector()
    {
        Transform hitObject = null;
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        if (hit)
        {
            if (hitInfo.transform.parent.GetComponent<Interactable>() != null)
            {
                Debug.Log("RaycastSelector Hit");
                hitObject = hitInfo.transform;
            }
        }
        return hitObject;
    }

    public void TryGetInventory()
    {
        this.selectedEntityInventory.items = this.selectedEntity.GetComponentInParent<Inventory>().items;
    }

    #endregion
}