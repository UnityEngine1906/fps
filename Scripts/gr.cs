using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gr : MonoBehaviour
{
    public float jump;
    public float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(rb.velocity.x, jump);
        rb.velocity = new Vector3(rb.velocity.y, speed);
    }
}
