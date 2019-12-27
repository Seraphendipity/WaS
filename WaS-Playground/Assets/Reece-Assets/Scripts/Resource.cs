using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Resource : MonoBehaviour
{
    public string resourceName;
    public int quantity;

    public void AddResource(int addQuantity)
    {
    
    }

    public Resource RemoveResource(int removeQuantity)
    {
    
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
        ResourceUI _UI = ResourceUI.Instantiate(resourceUIPrefab, content);
    }
    
    public void Refresh()
    {

    }
}

