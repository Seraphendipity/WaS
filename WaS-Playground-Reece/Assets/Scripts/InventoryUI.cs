using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public Transform content;
    public ItemUI itemUIPrefab;

    // Start is called before the first frame update
    void Start()
    {
        if (this.inventory != null) { Display(this.inventory); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // if a gameobject with an inventoryui is selected/clicked -> update the player's inventoryUI with this
    public void Display(Inventory i)
    {
        if (this.inventory) 
        {
            this.inventory.onChange.RemoveListener(Refresh); 
        }

        this.inventory = i;

        this.inventory.onChange.AddListener(Refresh);

        this.Refresh();
    }

    public void Refresh()
    {
        foreach (Transform t in content)
        { 
            Destroy(t.gameObject);
        }

        foreach (Item indexedItem in this.inventory.items)
        {
            Debug.Log("Item in inventory -> " + indexedItem.name);

            ItemUI ui = ItemUI.Instantiate(itemUIPrefab, this.content);
            ui.Display(indexedItem);
            ui.primaryAction.AddListener(UIClick); // FIXME: for a shop... what was clicked and who clicked it? move item to clicker's inventory, remove item from shop's inventory
                   // TODO: ui.secondaryAction.AddListener(contextSecondaryAction);
        }
    }

    //  TODO: public abstract void contextPrimaryAction(ItemUI item);
    //  TODO: public abstract void contextSecondaryAction(ItemUI item);


    public virtual void UIClick(ItemUI itemUI)
    {
         //Destroy(item.gameObject);
        this.inventory.RemoveItem(itemUI.item);

    }
    // TODO: public virtual void RegisterPlayerListener();

     // V    Code referenced by UnityEvents only V
    #region UnityEventResponders

    public virtual void AddToThisInventory(Item item)
    {

    }

    public virtual void RemoveFromThisInventory(Item item) { this.inventory.RemoveItem(item); }

    #endregion

}
