using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IAttackable, ICommandable, ISelectable
{
    public Player commander;
    public int hitPoints;

    public Interactable target;

    public void Attack(int damage)
    {
        Debug.Log("I am Interactable->IAttackable");
    }

    public void Command(Interactable i)
    {
        Debug.Log("Unit.Command(Interactable " + i + ")");
        this.Interact(i);
    }

    public void Interact(Interactable target)
    {
        this.target = target;
        target.Interact();
        Debug.Log("Unit.Interact(Interactable " + target + ")");
    }

    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    public void ListenTo(Player player, PlayerInputManager input)
    {
        this.commander = player;
        input.onInteractInput.AddListener(Interact);
    }

    public void MoveTo(Transform destination)
    {
        Vector3 move = Vector3.MoveTowards(this.transform.position, destination.position, 5);
        this.transform.position = move;
    }

    public void Select()
    {

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
