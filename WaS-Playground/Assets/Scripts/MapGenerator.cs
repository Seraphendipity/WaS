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
        Instantiate(pfItem, new Vector3(0,2,0), Quaternion.identity);
        Instantiate(pfFloor, Vector3.zero, Quaternion.identity);
        Instantiate(pfPlayer, new Vector3(0,0,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
