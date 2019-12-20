using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public Transform content;
    public ItemUI itemUIPrefab;

    // Start is called before the first frame update
    void Start()
    {
        if (this.inventory != null)
        {
            Display(this.inventory);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // if a gameobject with an inventoryui is selected/clicked -> update the player's inventoryUI with this
    public void Display(Inventory i)
    {
        this.inventory = i;
        this.Refresh();
    }
    public void Refresh()
    {
        foreach (Item indexedItem in this.inventory.items) {
            Debug.Log("Item in inventory -> " + indexedItem.name);
            ItemUI ui = ItemUI.Instantiate(itemUIPrefab, this.content);
            ui.Display(indexedItem);
        }
    }
}
