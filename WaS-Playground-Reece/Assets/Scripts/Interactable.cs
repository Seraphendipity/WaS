using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionBehaviour
{
    public Player alignment;
    public Transform target;
    public Transform targetOfTarget;
}

public interface Interactable 
{
    // Aligment 
    // Target
    // Target of Target
    // Events
    // EventResponders

    void Interact();
}
