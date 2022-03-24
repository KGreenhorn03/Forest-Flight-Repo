using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    // This is a custom function not built into unity.
    // We will call this function fro put hazard script.
    // Marked public so it can be accessed from a different script.
    public void kill()
    {


        // Destroy will delete/remove a game object
        // "gameObject" is the Game Object this script is attached to.
        Destroy(gameObject);

    }



}
