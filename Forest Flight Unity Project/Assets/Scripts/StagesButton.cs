using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StagesButton : MonoBehaviour
{

    public string stage;

    public void Stage()
    {

        SceneManager.LoadScene(stage);

    }

    public void Quit()
    {

        Application.Quit();

    }

}
