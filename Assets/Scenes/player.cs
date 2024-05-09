using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public float rotationSpeed = 100f; // ���� �������
    public AudioClip AudioClip;

    private Rigidbody rb;
    private bool isGrounded;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        UnityEngine.AudioClip Playerjump = AudioClip;
    }

    void Update()
    {
        // ���� ������
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);

        float angle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0, angle, 0);
        rb.AddForce(moveDirection * moveSpeed);

        // �����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = true;

            // ����� ����� ��� �����
            //AudioClip.
        }

        // ������� �������� ������ A � D
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }

        // ������ ������ ������ ��������  W � S
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * moveSpeed * Time.deltaTime;
        }
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    // ������ �� �� ������ ��� �����
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        isGrounded = true;
    //    }
    //}
}
