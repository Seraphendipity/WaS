using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddItem(Item item)
    {
        Item.Instantiate(item, this.transform);
    }
    public bool RemoveItem(Item item)
    {
        foreach (Item i in this.items) {
            if (i.name == item.name) {
                Destroy(i);
                return true;
            } 
        }
        return false;
    }
}
