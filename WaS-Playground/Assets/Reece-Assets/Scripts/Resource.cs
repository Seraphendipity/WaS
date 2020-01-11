using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Resource : MonoBehaviour, Interactable
{
    public string resourceName;
    public int quantity;

    public void AddResource(int addQuantity)
    {
    
    }

    public void Interact()
    {
    }

    public void LeftClick()
    {
        Debug.Log("Resource LeftClick()");
    }

    public void RemoveResource(int removeQuantity)
    {
    
    }

    public void RightClick()
    {
        Debug.Log("Resource RightClick()");
    }
}

public class ResourceUI : MonoBehaviour
{
    public Resource resource;
    public GameObject resourceUIPrefab;
    public Transform content;

    private void Start()
    {
        if (resource != null) {
            Display(resource);
        }
    }


    public void Display(Resource resource)
    {
        //ResourceUI _UI = ResourceUI.Instantiate(resourceUIPrefab, content);
    }
    
    public void Refresh()
    {

    }
}

