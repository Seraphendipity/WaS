using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour
{

    public GameObject hand;
    private Transform handleTrans;
    private Vector3 handleDiff;

    private void Awake() {
        handleTrans = transform.Find("Handle");
        Debug.Log("HANDLE TRANS: " + handleTrans);
        Debug.Log("HANDLE POS: " + handleTrans.localPosition);
        Debug.Log("SWORD POS: " + transform.localPosition);
        handleDiff = new Vector3(0,0,handleTrans.localScale.z + transform.localScale.z);
    }

    private void OnMouseDown() {
        if(transform.parent == null) {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.SetParent(hand.transform);
            transform.localPosition = Vector3.zero + handleDiff;
            //handleTrans.localPosition = transform.position;
            transform.rotation = hand.transform.rotation;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            GetComponent<BoxCollider>().isTrigger = true;
        } else {
            transform.parent = null;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
