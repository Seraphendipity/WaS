using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Resource : MonoBehaviour, ICollectable
{
    public int quantity;

    public int Collect(int amount)
    {
        return 1;
    }

    public void Interact(Interactable i)
    {
        Debug.Log("Interacted with resource");
    }

    public void Interact()
    {
        Debug.Log("Interacted with resource");
    }

    // Start is called before the first frame update
    void Start()
    {
        this.quantity = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
