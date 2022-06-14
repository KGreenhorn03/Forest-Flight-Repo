using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
  
        if (score == 100)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
       
    }

}
