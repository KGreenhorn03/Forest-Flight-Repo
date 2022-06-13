using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private int score;
    public Text scoreDisplay;
    private void OnTriggerExit2D(Collider2D collision)
    {

        score++;
        scoreDisplay.text = score.ToString();

    }

    void Update()
    {
  

       
    }

}
