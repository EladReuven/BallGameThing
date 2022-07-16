using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializedMovement : MonoBehaviour
{

    public Vector3 v3Force;
    public KeyCode positiveKey;
    public KeyCode negativeKey;
    

    // Update is called once per frame
    void Update()
    {
        // v3Force = rawV3Force.normalized * Time.deltaTime;
        if (Input.GetKey(positiveKey))
            GetComponent<Rigidbody>().velocity += v3Force * Time.deltaTime;

        if (Input.GetKey(negativeKey))
            GetComponent<Rigidbody>().velocity -= v3Force * Time.deltaTime;
    }

}
