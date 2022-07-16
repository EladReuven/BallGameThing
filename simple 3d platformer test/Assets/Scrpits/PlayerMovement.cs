using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public CharacterController Controller;


    public float speed = 5.00f;
    public Rigidbody rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(vertical * -1, 0f, horizontal).normalized;

        if (direction.magnitude >= 0.1f)
        {
            rb.AddRelativeForce(direction.normalized * speed * Time.deltaTime);

           //transform.Translate(direction.normalized * speed * Time.deltaTime);
        }

    }
}
