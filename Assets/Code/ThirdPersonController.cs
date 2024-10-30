using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour {

    public float Speed;

    public Vector3 jump;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }


    void Update () {
        PlayerMovement();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

    }
    void OnCollisionExit(Collision other)
    {
        
        if (other.gameObject.tag == "Ground")
            {
                isGrounded = false;
            }
        
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    void PlayerMovement()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vertic = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(horiz, 0f, vertic).normalized * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }

}
