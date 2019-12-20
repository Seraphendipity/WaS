using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items;

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
        Item.Instantiate(item, this.transform);
    }
    public void RemoveItem(Item item)
    {
        items.Remove(item);

    }
}
