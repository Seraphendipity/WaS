using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommandable : Interactable
{
    void Command(Interactable i);
}
