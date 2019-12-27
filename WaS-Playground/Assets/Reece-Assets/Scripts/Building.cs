using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour, Interactable
{
    public PlayerInputManager inputManager;
    // public GameObject pfPlayer;

    public void Interact()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetMouseButtonDown(0)) {
        //      var hit: RaycastHit;
        //      var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             
        //      if (Physics.Raycast(ray, hit)) {
        //          if (hit.transform.name == "Building" ) {
        //             Instantiate(pfPlayer, new Vector3(0,0,0), Quaternion.identity);
        //          }
        //      }
        //  }
    }
}
