using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StagesButton : MonoBehaviour
{

    // Declare variable.

    public string stage;

    public void Stage()
    {

        // Makes the chosen scene load when function is called..

        SceneManager.LoadScene(stage);

    }

    public void Quit()
    {

        // Quits the program.

        Application.Quit();

    }

}
