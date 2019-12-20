using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IAttackable, ICommandable, IMoveable
{
    public Player commander;
    public int hitPoints;

    public void Attack(int damage)
    {
        Debug.Log("I am Interactable->IAttackable");
    }

    public void Command(Interactable target)
    {
        Debug.Log(this.name + " is interacting with " + target);
        target.Interact();
    }


    public void MoveTo(Transform destination)
    {
        Vector3 move = Vector3.MoveTowards(this.transform.position, destination.position, 5);
        this.transform.position = move;
    }

    public void Interact()
    {
        if (this.commander == null)
        {
            Attack(3);
        }
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
