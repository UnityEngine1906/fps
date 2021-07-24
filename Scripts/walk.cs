using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public CharacterController controller;
    public float speed;
    public float maspeed;
    public float minspeed;
    Vector3 velocity;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float graunddistance = 0.4f;
    public LayerMask graundmask;
    bool isgraund;
    public int jumpForce;
    public AudioClip Walking;
    public AudioSource проигрыавтель;
    Rigidbody rb;
    private bool iswalk = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isgraund = Physics.CheckSphere(groundCheck.position, graunddistance, graundmask);
        if (isgraund && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;

        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        Jump();
    }
    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && isgraund)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2 * gravity);
        }
    }
}