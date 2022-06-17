using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{

    // Declare variables

    private int score;
    public Text scoreDisplay;

    // When the player exits the collider by going through the obstacle, they gain a point.

    private void OnTriggerExit2D(Collider2D collision)
    {

        score++;
        scoreDisplay.text = score.ToString();

    }


    // Update is called once per frame.
    void Update()
    {
  
        // If the player scores 100 points they win the game.

        if (score == 100)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
       
    }

}
