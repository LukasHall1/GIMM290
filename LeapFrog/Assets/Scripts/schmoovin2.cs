using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schmoovin2 : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.I)) {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.J)) {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.L)) {
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.K)) {
            transform.position += transform.up * speed * Time.deltaTime;
        }

    }
}
