using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerInputManager : MonoBehaviour
{
    public Player player;
    public Transform selectedEntity;
    public Inventory selectedEntityInventory;
    public PlayerRaycaster playerRaycaster;

    // Start is called before the first frame update
    void Start()
    {
        if (player != null)
        {
            Debug.Log("PlayerInputManager: Initialized with Player " + player.playerName);
            playerRaycaster = new PlayerRaycaster(player);
        } 

        else
        {
            Debug.LogError("PlayerInputManager: There needs to be a Player object referenced by this Component.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Button 0");
            playerRaycaster.LeftClick();
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Mouse Button 1");
            playerRaycaster.RightClick();
        }
    }

    #region Helper Functions

    public void TryGetInventory()
    {
        this.selectedEntityInventory.items = this.selectedEntity.GetComponentInParent<Inventory>().items;
    }

    #endregion
}