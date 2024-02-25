using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tagged2 : MonoBehaviour
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
        if (other.gameObject.tag == "Player1")
        {
            tag += 1;
            scoreText.text = "Player 2: " + tag.ToString(); // Update the score text
            if (tag == 4)
            {
                Winner.text = "Player 2 Wins!";
            }
        }
    }
}
