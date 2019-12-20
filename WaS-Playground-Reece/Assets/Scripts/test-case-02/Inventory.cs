using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#region UnityEventDispatchers
[System.Serializable]
public class InventoryChangeEvent : UnityEvent {}
#endregion

public class Inventory : MonoBehaviour
{
    public List<Item> items;

    #region InventoryEvents
    public InventoryChangeEvent onChange; // Alert intrested to respond to this inventory change.
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //Inventory.Instantiate(InventoryPrefab, gameObject parent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddItem(Item item)
    {
        //Item.Instantiate(item, this.transform);
        items.Add(item);
        onChange.Invoke();
    }
    public void RemoveItem(Item item)
    {
        items.Remove(item);
        onChange.Invoke();
    }
}
