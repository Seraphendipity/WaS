using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, Interactable
{
    public Player commander;
    public int hitPoints;

    public void Spawn(Player owner)
    {
        this.commander = owner;
    }

    public void Interact()
    {

    }

    public void LeftClick()
    {
        Debug.Log("Unit LeftClick()");
    }

    public void RightClick()
    {
        Debug.Log("Unit RightClick()");
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
