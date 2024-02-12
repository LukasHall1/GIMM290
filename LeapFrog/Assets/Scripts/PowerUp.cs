using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            player1.GetComponent<schmoovin>().speed += 5;
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            player2.GetComponent<schmoovin2>().speed += 5;
            Destroy(this.gameObject);
        }
    }
}
