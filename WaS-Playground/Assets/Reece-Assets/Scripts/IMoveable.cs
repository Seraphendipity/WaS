using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMoveable : Interactable
{
    void MoveTo(Transform destination); 
}