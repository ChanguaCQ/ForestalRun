using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    private float fallForce;
    public float gravityModifier;
    void Start()
    {
        fallForce = jumpForce * 1.6f;
        playerRb = GetComponent<Rigidbody>();
        // Modifica la gravedad global del motor de física multiplicándola por gravityModifier
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
           playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
        };

        if (Input.GetKeyDown(KeyCode.S)){
           playerRb.AddForce(Vector3.down * fallForce, ForceMode.Impulse); 
        };
    }
}
