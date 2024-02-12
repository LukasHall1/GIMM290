using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tagged2 : MonoBehaviour
{
    public int tag = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Player 2 score: " + tag);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player1") {
            tag += 1;
        }
    }
}
