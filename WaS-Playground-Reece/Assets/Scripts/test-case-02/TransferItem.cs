using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class SellEvent : UnityEvent<Item, Inventory, Inventory> {}

public class TransferItem : MonoBehaviour
{

    public SellEvent onSell;

    public void Purchase(Item item, Inventory source, Inventory destination)
    {
        //if (source.Vd
    }

    public void Sell()
    {

    }

    void Update()
    {
    }

}
