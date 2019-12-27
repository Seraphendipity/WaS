using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private int points;
    private float height;
    public Text pointsText;
    public Text winText;

    private Vector3 worldpos = new Vector3(0,2,0);
    private Vector3 worldposVarY = new Vector3(0,2,0);
    private float mouseX;
    private float mouseY;
    private float cameraDif;
    private Vector3 velocityVector = Vector3.zero;
    private Vector3 inputVector = Vector3.zero;
    private Vector3 decelerationVector;
    private Quaternion lookDirection;
    private Quaternion zeroY = Quaternion.Euler(new Vector3(0,1,0));

    public Camera cam;
    Animator anim;
    Transform head;

    public GameObject pfCastle;

    // Player ID
    // Neither uName nor uNum are unique, but the combination of them is
    public string uName; // Seraphendipity, neoreece, etc.
    public string uNum; // #1578, #1895, etc.
    public bool bHuman; // Controlled by AI (F) or Player (T)

    // Start is called before the first frame update
    private void Awake() {
        rb = GetComponent<Rigidbody>();
        points = 0;
        IncrementPointValue(0);
       // winText.enabled = false;

        anim = GetComponent<Animator>();
        Debug.Log(anim);


        height = this.GetComponent<BoxCollider>().size.y; //TODO: Attach to Eye Height
        cameraDif = cam.transform.position.y - this.transform.position.y + height;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
    }

    void OnTriggerEnter( Collider oc) {
        GameObject o = oc.gameObject;
        // oc = ObjectCollider, NOT the object itself
        if( o.CompareTag("Item")) {
            o.SetActive(false);
            IncrementPointValue();
        }
    }

    void IncrementPointValue() {
        //pointsText.text = "Count: " + (++points).ToString();
        IncrementPointValue(1);
    }

    void IncrementPointValue(int i) {
        // points += i;
        // pointsText.text = "Count: " + points.ToString();
        // if (points >= 3) {
        //     winText.enabled = true;
        // }
    }


}