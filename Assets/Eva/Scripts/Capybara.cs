using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capybara : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 1f;
    private Vector3 moveVector;
    void Start()
{
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.z = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    }
}
