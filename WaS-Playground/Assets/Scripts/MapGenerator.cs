using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject pfPlayer;
    public GameObject pfFloor;
    public GameObject pfItem;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pfFloor, Vector3.zero, Quaternion.identity);
        Instantiate(pfPlayer, new Vector3(0,0,0), Quaternion.identity);
        for(int i = 0; i < Random.Range(3,10); i++) {
            RandomItem();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void RandomItem() {
        Vector3 randPosition = new Vector3(Random.Range(-10.0f, 10.0f), 0.75f, Random.Range(-10.0f, 10.0f));
        Instantiate(pfItem, randPosition, Quaternion.identity);
    }
}
