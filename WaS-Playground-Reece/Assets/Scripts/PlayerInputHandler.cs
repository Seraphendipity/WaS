using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    /// <summary>
    /// Methods applied to this allow motion.
    /// </summary>
    public Rigidbody me; 

    // Start is called before the first frame update
    void Start()
    {
        me = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Provides slight acceleration boost on key down.
        if (Input.GetButtonDown("Forward")) {
            me.AddRelativeForce(0, 0, 5, ForceMode.Impulse);
        }

        if (Input.GetButton("Forward")) {
            Debug.Log("Pressing Forward Key");
            me.AddRelativeForce(0, 0, 10, ForceMode.Acceleration);
        } 

        // Provides slight acceleration boost on key down.
        if (Input.GetButtonDown("Backward")) {
            me.AddRelativeForce(0, 0, -5, ForceMode.Impulse);
        }

        if (Input.GetButton("Backward")) {

            me.AddRelativeForce(0, 0, -10, ForceMode.Acceleration);
        } 

        if (Input.GetButton("Left")) {
            Debug.Log("Pressing Left Key");
            me.AddRelativeTorque(0, -5, 0, ForceMode.VelocityChange);
        } 

        if (Input.GetButton("Right")) {
            Debug.Log("Pressing Right Key");
            me.AddRelativeTorque(0, 5, 0, ForceMode.VelocityChange);
       }
    }

    /// <summary>
    ///
    /// </summary>
    public void Forward()
    {

    }

    /// <summary>
    ///
    /// </summary>
    public void Backward()
    {

    }

    /// <summary>
    ///
    /// </summary>
    public void Left()
    {

    }

    /// <summary>
    ///
    /// </summary>
    public void Right()
    {

    }
}
