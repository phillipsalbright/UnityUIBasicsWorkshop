using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(-50f, 0, 0), ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(50f, 0, 0), ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0f, 50), ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -50), ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 2f, 0), ForceMode.Impulse);
        }

    }
}
