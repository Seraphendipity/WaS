using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Vector3 maxVelocity = new Vector3(2,0,1f);
    //public Vector3 acceleration = new Vector3(1,0,1);
    //public Vector3 deceleration = new Vector3(1,0,1);
    public float accelerationMod = 0.2f;
    public float decelerationMod = 1f;
    public float moveSpeedMod = 1f;
    public float turningSpeedMod = 100f;
    public float headUpSpeed = 5f;
    public float maxSpeed = 5f;
    public float jumpMod = 1f;
    public float backwardSpeedMultiplier = 1f;
    private Vector3 moveSpeed = new Vector3(0,0,0);
    private Vector3 jumpDir = new Vector3(0,2,0);
    private Rigidbody rb;
    private int points;
    private float height;
    private bool bGrounded;
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
        MovePlayer();
        AnimatePlayer();
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

    void OnCollisionStay(Collision collision) {
        bGrounded = true;
    }
    

    private void MovePlayer() {
        mouseX = Input.mousePosition.x;
        mouseY = Input.mousePosition.y;
        worldpos = cam.ScreenToWorldPoint(new Vector3(mouseX, mouseY-cam.WorldToScreenPoint(transform.position).y, cameraDif));
        //lookDirection = Quaternion.FromToRotation( transform.forward,  cam.ScreenToWorldPoint(new Vector3(mouseX, 0,mouseY)) - transform.position);
        lookDirection = Quaternion.LookRotation(worldpos - transform.position, Vector3.up);

       // inputVector = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 inputVectorX = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        Vector3 inputVectorY = new Vector3(0, 0, Input.GetAxisRaw("Vertical"));
        inputVectorX = Vector3.RotateTowards(inputVectorX, transform.right, 4, 0)*Input.GetAxisRaw("Horizontal");
        inputVectorY = Vector3.RotateTowards(inputVectorY, transform.forward, 4, 0)*Input.GetAxisRaw("Vertical");
        inputVector = inputVectorX + inputVectorY;

        if( !inputVector.Equals(Vector3.zero) ) {
            //if(velocityVector.magnitude < maxSpeed) { //TODO: Change to vector maxSpeed
                velocityVector += Vector3.Normalize(inputVector) * accelerationMod;
                velocityVector = Vector3.ClampMagnitude(velocityVector, maxSpeed);
                transform.rotation = Quaternion.Euler(0, Quaternion.Lerp(transform.rotation, lookDirection, Time.deltaTime * turningSpeedMod).eulerAngles.y, 0);
            //}
        } else {
            decelerationVector = Vector3.Normalize(velocityVector) * decelerationMod;
            if( velocityVector.magnitude > decelerationVector.magnitude ) {
                velocityVector -= decelerationVector;
            } else {
                velocityVector = Vector3.zero;
            }
        }
        rb.MovePosition(transform.position + (velocityVector * Time.deltaTime));
        if(Input.GetKeyUp(KeyCode.Space) && bGrounded) {
            rb.AddForce(jumpDir * jumpMod, ForceMode.Impulse);
            bGrounded = false;
        }
       //LookAtMouse();
        //rb.MovePosition(Vector3.Lerp(transform.position, transform.position + (vMovement * moveSpeedMod * Time.fixedDeltaTime), Time.fixedDeltaTime));
    }

    private void AnimatePlayer() {
        float animSpeed;
        if(Input.GetAxisRaw("Vertical") != 0) {
            animSpeed = 1f;
        } else {
            animSpeed = 0f;
        }
        Debug.Log("AnimSpeed: " + animSpeed);
        anim.SetFloat("speed", animSpeed);

    }

    private void OnAnimatorIK(int layerIndex) {
        
  //  }
//
    //void LookAtMouse()
  //  {//
        //TODO: bug, bases on real screen, not game screen window size

        float height = 5;
        Vector3 lookWithY = worldpos;
        Vector3 lookSansY = new Vector3(worldpos.x, 0, worldpos.z);
        if(worldpos.y+height>=0) {
            worldposVarY = Vector3.Lerp(worldposVarY, lookWithY, Time.deltaTime * headUpSpeed);
        } else {
            worldposVarY = Vector3.Lerp(worldposVarY, lookSansY, Time.deltaTime * headUpSpeed);
        }
        anim.SetLookAtWeight(1);
        
        anim.SetLookAtPosition(worldposVarY);
        //Vector3 lookDir = new Vector3 (worldpos.x,this.transform.position.y, worldpos.z);
        //anim.SetBoneLocalRotation(HumanBodyBones.Head, Quaternion.LookRotation(lookDir,Vector3.up));
        //head.LookAt(lookDir);

        // //TODO: bug, bases on real screen, not game screen window size
        // mouseX = Input.mousePosition.x;
        // mouseY = Input.mousePosition.y;

        // Debug.Log(mouseY);
        
        // worldpos = camera.ScreenToWorldPoint(new Vector3(mouseX, mouseY, cameraDif));
        // Vector3 lookDir = new Vector3 (worldpos.x,this.transform.position.y, worldpos.z);
        
        // this.transform.LookAt(lookDir);
    }

    

    // private void MovePlayer() {
    //     //TODO: REPLACE WITH KINEMATIC SYSTEM
    //     float xMove = Input.GetAxisRaw("Horizontal");
    //     float zMove = Input.GetAxisRaw("Vertical");
    //     Vector3 mPos = Input.mousePosition; //TODO: Handle if - or above screen dims

    //     Vector2 mouse = new Vector2(mPos.x, mPos.y);
    //     Ray ray = Camera.main.ScreenPointToRay(mouse);
    //     RaycastHit hit; // TODO: Is there a better way? what if end of map?

    //     if(Physics.Raycast(ray,out hit, 50))
    //     {
    //         // DIRECTION
    //         float dx = hit.point.x-transform.position.x;
    //         float dz = hit.point.z-transform.position.z;
    //         Vector3 dv = new Vector3(dx,0,dz).normalized;
    //         Vector3 dvo = Vector3.Cross(dv, Vector3.up);

    //         // SPEED
    //         float xOppDirMul = Mathf.Sign(xMove * moveSpeed.x) + 1;
    //         float zOppDirMul = Mathf.Sign(zMove * moveSpeed.z) + 1;
    //         moveSpeed.x += acceleration.x * xMove * xOppDirMul;
    //         moveSpeed.z += acceleration.z * zMove * zOppDirMul;
    //         if (Mathf.Approximately(zMove,-1)) {
    //             moveSpeed.z *= backwardSpeedMultiplier;
    //         }

    //         limitVector3(moveSpeed, maxVelocity);
                
    //         if (Mathf.Approximately(zMove,0) && !Mathf.Approximately(moveSpeed.z, 0)) {
    //             moveSpeed.z = Vector3.Lerp(new Vector3(0,0,moveSpeed.z), Vector3.zero, Time.fixedDeltaTime * deceleration.z).z;
    //         }
    //         if (Mathf.Approximately(xMove,0) && !Mathf.Approximately(moveSpeed.x, 0)) {
    //             moveSpeed.x = Vector3.Lerp(new Vector3(moveSpeed.x,0,0), Vector3.zero, Time.fixedDeltaTime * deceleration.x).x;
    //         }
    //         Vector3 movement = ( (dv * moveSpeed.z) + (dvo * moveSpeed.x) )
    //             * Time.fixedDeltaTime;
    //         transform.Translate(movement);
    //     }

    //     //this.transform.Translate(movement);
    //     //rb.AddRelativeForce(movement);
    // }

    // private void limitVector3(Vector3 inputVector, Vector3 maxVector) {
    //     if(inputVector.x > maxVector.x) {
    //         inputVector.x = maxVector.x;}
    //     if(inputVector.y > maxVector.y) {
    //         inputVector.y = maxVector.y;}
    //     if(inputVector.z > maxVector.z) {
    //         inputVector.z = maxVector.z;}
    // }

}