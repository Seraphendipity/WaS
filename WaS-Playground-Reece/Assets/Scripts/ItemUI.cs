using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    public Item item;
    public Text itemName;

    // Start is called before the first frame update
    void Start()
    {
        if (item != null) {
            Display(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Display(Item item)
    {
        this.item = item;
        this.itemName.text = this.item.name;
    }
    public void onClick()
    {
        Destroy(item.gameObject);
        Destroy(this.gameObject);
    }
}
