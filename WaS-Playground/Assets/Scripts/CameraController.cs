using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WaS;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    public Vector3 offset; //= new Vector3(0,5,-5);
    //public Vector3 initRotation = new Vector3(45,0,0);

    private float offsetMultiplier = 1;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Late Update to waIt till after player has moved
        RotateCamera();
        offsetMultiplier -= Input.GetAxis("Mouse ScrollWheel") * ResourceManager.Scrolling.scrollDistance;
        //transform.position = player.transform.position + (offset * offsetMultiplier); //Vector3.Lerp(transform.position, player.transform.position + (offset * offsetMultiplier), ResourceManager.Scrolling.scrollSpeed * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, player.transform.position + (offset * offsetMultiplier), ResourceManager.Scrolling.scrollSpeed * Time.time);
    }

    private void RotateCamera() {
        Vector3 origin = transform.eulerAngles;
        Vector3 destination = Vector3.zero;
        
        //detect rotation amount if ALT is being held and the middle mouse button is down
        if( Input.GetKey(KeyCode.LeftAlt) || Input.GetMouseButton(2)) {
            destination.x -= Input.GetAxis("Mouse Y") * ResourceManager.Scrolling.rotateDistance;
            destination.y += Input.GetAxis("Mouse X") * ResourceManager.Scrolling.rotateDistance;
        }
        
        //if a change in position is detected perform the necessary update
        if(destination != Vector3.zero) {
            // TODO: Allow rotting while moving
            //offset = Vector3.Lerp(transform.position, player.transform.position + (offset * offsetMultiplier), ResourceManager.Scrolling.scrollSpeed * Time.time) - player.transform.position;
            transform.RotateAround(player.transform.position, player.transform.up, ResourceManager.Scrolling.rotateDistance * Time.deltaTime * destination.y);
            transform.RotateAround(player.transform.position, transform.right, ResourceManager.Scrolling.rotateDistance * Time.deltaTime * destination.x);
            offset = (transform.position - player.transform.position)/offsetMultiplier;
            //transform.eulerAngles = Vector3.MoveTowards(origin, destination, Time.deltaTime * ResourceManager.Scrolling.rotateSpeed);
        }
    }
}
