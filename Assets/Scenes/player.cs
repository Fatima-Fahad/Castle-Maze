using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
        rb.AddForce(moveDirection * moveSpeed);

        // Jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    
}














//public class player : MonoBehaviour
//{
//    private Vector3 PlayMov;
//    private Vector2 PlayMouse;

//    private Rigidbody PlayerBode;
//    public float moveSpeed ;
//    public float jumpForce ;
//    //Â–« ⁄·‘«‰ Õ—ﬂ… «·„«Ê”
//    public float sensitvty ;

//    //Â‰« «÷›  Â–« ⁄·‘«‰   Õ—ﬂ «·ﬂ«„Ì—« 
//    public Transform PlayCam ;


//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        float horizontalInput = Input.GetAxis("Horizontal");
//        float verticalInput = Input.GetAxis("Vertical");
//        PlayMov = new Vector3(horizontalInput, 0f, verticalInput);

//        float X = Input.GetAxis("Mouse x");
//        float Y = Input.GetAxis("Mouse y");
//        PlayMouse = new Vector2(X, Y);

//        MovePlayer();
//        MoveCamera();
//    }

//    //-----›‰ﬂ‘‰ Õ—ﬂ… «·«⁄» --------
//    private void MovePlayer()
//    {
//        Vector3 MoveVector = transform.TransformDirection(PlayMov) * moveSpeed;
//        PlayerBode.velocity = new Vector3 (M)
//    }


//    //-----›‰ﬂ‘‰ «·ﬂ«„Ì—« ---------
//    private void MoveCamera()
//    {

//    }



//}


