using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementController : MonoBehaviour
{
    public float velocityMod = 100f;
    public float accelerationMod = 0.2f;
    public float jumpMod = 25f;
    public int jumpInput = 1;
    private Rigidbody rb;
    Animator animator;
    private Vector3 inputVector = Vector3.zero;
    private Vector3 velocity = Vector3.zero;
    private bool bGrounded;
    private Vector3 acceleration = Vector3.zero;
    public float maxSpeed = 5f;

    public float headUpSpeed = 5f;
    private Vector3 worldpos = new Vector3(0,2,0);
    private Vector3 worldposVarY = new Vector3(0,2,0);
    private float mouseX;
    private float mouseY;
    private float cameraDif;



    private void Awake() {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        MoveInput();
    }

    void FixedUpdate() {
        MovePhysics();
    }

    void OnCollisionStay(Collision collision) {
        bGrounded = true;
    }
    
    private void MoveInput() {
        if(Input.GetKeyUp(KeyCode.Space) && bGrounded) {
            jumpInput = 1;
            bGrounded = false;
        }
    }

    private void MovePhysics() {
        mouseX = Input.mousePosition.x;
        mouseY = Input.mousePosition.y; 
        inputVector = Vector3.Normalize(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")));
//        anim.SetFloat("speed", velocityVector.magnitude/maxSpeed);
        //acceleration = inputVector * accelerationMod;
        velocity = inputVector * velocityMod;
        //inputVector = Vector3.zero;
        //velocity += acceleration;
        //Vector3.ClampMagnitude(velocity, maxSpeed);
        animator.SetFloat("speed", velocity.magnitude/maxSpeed);
        rb.MovePosition(transform.position + (velocity * Time.fixedDeltaTime));

        if((jumpInput != 0) && bGrounded) {
            rb.AddForce(Vector3.up * jumpMod * jumpInput, ForceMode.Impulse);
            jumpInput = 0;
        }


    }

    private void OnAnimatorIK(int layerIndex) {
        

    //     private void MoveInput() {
    //     mouseX = Input.mousePosition.x;
    //     mouseY = Input.mousePosition.y; 
    //     inputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    // }

    // private void MovePlayer() {
    //     worldpos = cam.ScreenToWorldPoint(new Vector3(mouseX, mouseY-cam.WorldToScreenPoint(transform.position).y, cameraDif));
    //     //lookDirection = Quaternion.FromToRotation( transform.forward,  cam.ScreenToWorldPoint(new Vector3(mouseX, 0,mouseY)) - transform.position);
    //     lookDirection = Quaternion.LookRotation(worldpos - transform.position, Vector3.up);

    //     Vector3 inputVectorX = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
    //     Vector3 inputVectorY = new Vector3(0, 0, Input.GetAxisRaw("Vertical"));
    //     inputVectorX = Vector3.RotateTowards(inputVectorX, transform.right, 4, 0)*Input.GetAxisRaw("Horizontal");
    //     inputVectorY = Vector3.RotateTowards(inputVectorY, transform.forward, 4, 0)*Input.GetAxisRaw("Vertical");
    //     inputVector = inputVectorX + inputVectorY;

    //     if( !inputVector.Equals(Vector3.zero) ) {
    //         //if(velocityVector.magnitude < maxSpeed) { //TODO: Change to vector maxSpeed
    //             velocityVector += Vector3.Normalize(inputVector) * accelerationMod;
    //             velocityVector = Vector3.ClampMagnitude(velocityVector, maxSpeed);
    //             transform.rotation = Quaternion.Euler(0, Quaternion.Lerp(transform.rotation, lookDirection, Time.deltaTime * turningSpeedMod).eulerAngles.y, 0);
    //         //}
    //     } else {
    //         decelerationVector = Vector3.Normalize(velocityVector) * decelerationMod;
    //         if( velocityVector.magnitude > decelerationVector.magnitude ) {
    //             velocityVector -= decelerationVector;
    //         } else {
    //             velocityVector = Vector3.zero;
    //         }
    //     }
    //     rb.MovePosition(transform.position + (velocityVector * Time.deltaTime));
    //     Debug.Log(velocityVector.magnitude);
    //     anim.SetFloat("speed", velocityVector.magnitude/maxSpeed);

    //     if(Input.GetKeyUp(KeyCode.Space) && bGrounded) {
    //         rb.AddForce(jumpDir * jumpMod, ForceMode.Impulse);
    //         bGrounded = false;
    //     }
    //    //LookAtMouse();
    //     //rb.MovePosition(Vector3.Lerp(transform.position, transform.position + (vMovement * moveSpeedMod * Time.fixedDeltaTime), Time.fixedDeltaTime));
    // }
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
        animator.SetLookAtWeight(1);
        
        animator.SetLookAtPosition(worldposVarY);
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

//         private void MoveInput() {
//         mouseX = Input.mousePosition.x;
//         mouseY = Input.mousePosition.y; 
//         inputVector += Vector3.Normalize(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")));
//         if(Input.GetKeyUp(KeyCode.Space) && bGrounded) {
//             jumpInput = 1;
//             bGrounded = false;
//         }
//     }

//     private void MovePhysics() {
// //        anim.SetFloat("speed", velocityVector.magnitude/maxSpeed);
//         acceleration = inputVector * accelerationMod;
//         inputVector = Vector3.zero;
//         velocity += acceleration * velocityMod;
//         Vector3.ClampMagnitude(velocity, maxSpeed);
//         animator.SetFloat("speed", velocity.magnitude/maxSpeed);
//         rb.MovePosition(transform.position + (velocity * Time.fixedDeltaTime));

//         if((jumpInput != 0) && bGrounded) {
//             rb.AddForce(Vector3.up * jumpMod * jumpInput, ForceMode.Impulse);
//             jumpInput = 0;
//         }


//     }

}ggg