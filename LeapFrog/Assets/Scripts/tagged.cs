using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tagged : MonoBehaviour
{
    public int tag = 0;
    public TMP_Text scoreText;
    public TMP_Text Winner;

    void Start()
    {
        Winner.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {
            tag += 1;
            scoreText.text = "Player 1: " + tag.ToString(); // Update the score text
            if (tag == 4)
            {
                Winner.text = "Player 1 Wins!";
            }
        }
    }
}
