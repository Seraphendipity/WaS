using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public string playerColor;

    // Start is called before the first frame update
    void Start()
    {
        if (playerName != null && playerColor != null)
        {
            Debug.Log("Started game with player " + playerName + " and color " + playerColor + ".");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
