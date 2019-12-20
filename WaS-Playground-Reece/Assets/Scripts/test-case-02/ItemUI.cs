using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class ItemUIEvent : UnityEvent<ItemUI> {}

public class ItemUI : MonoBehaviour
{
    public Item item;
    public Text itemName;
    public ItemUIEvent primaryAction;
    public ItemUIEvent secondaryAction;

    // Start is called before the first frame update
    void Start()
    {
        if (item != null) {
            Display(item);
        }
    }

    public void Display(Item item)
    {
        this.item = item;
        this.itemName.text = this.item.name;
    }
    
    /// <summary>
    /// Upon user Inputting the primary key (Left Click) on this ItemUI,
    /// perform the primary action relevant to the context.
    /// </summary>
    /// <remark>
    /// In a shop, the ShopInventoryUI will sell the item and move it
    /// it to the player's inventory.
    /// </remark>
    public void onPrimary()
    {
        primaryAction.Invoke(this);
    }
    public void onSecondary()
    {
        secondaryAction.Invoke(this);
    }
}
