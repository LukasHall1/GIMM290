using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schmoovin : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)) {
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)) {
            transform.position += transform.up * speed * Time.deltaTime;
        }

    }
}
