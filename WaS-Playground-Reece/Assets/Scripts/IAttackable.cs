using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackable : Interactable
{
    void Attack(int damage);
}
