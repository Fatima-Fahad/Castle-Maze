using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeing : MonoBehaviour
{
    public CharacterController controller;
    public float Speed = 5f;


    public void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);

        float angle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0, angle, 0);
        controller.Move(new Vector3(0, 0, 0)*Time.deltaTime);
     
    }
}