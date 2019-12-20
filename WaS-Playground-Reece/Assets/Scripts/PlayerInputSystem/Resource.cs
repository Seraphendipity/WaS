using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour, Interactable
{
    public int quantity;

    public void CollectResource(int amount)
    {
        quantity -= amount;
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
