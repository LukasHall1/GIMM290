using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tagged : MonoBehaviour
{
    public int tag = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Player 1 score: " + tag);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player2") {
            tag += 1;
        }
    }
}
