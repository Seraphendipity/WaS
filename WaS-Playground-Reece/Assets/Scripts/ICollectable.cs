using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollectable : Interactable
{
    int Collect(int amount);
}
