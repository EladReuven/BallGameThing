using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SerializedMovement : MonoBehaviour
{



    public UnityEvent resetVelocity;
    public Vector3 v3Force;
    public KeyCode positiveKey;
    public KeyCode negativeKey;
    public Vector3 hardStop = new Vector3(0.05f, 0.05f, 0.05f);
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        resetVelocity.AddListener(velocityZero);
    }

    // Update is called once per frame
    void Update()
    {
        // v3Force = rawV3Force.normalized * Time.deltaTime;
        if (Input.GetKey(positiveKey))
            rb.velocity += v3Force * Time.deltaTime;

        if (Input.GetKey(negativeKey))
            rb.velocity -= v3Force * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            resetVelocity.Invoke();
        }

    }
    public void velocityZero()
    {
        rb.velocity = hardStop;
    }

}
