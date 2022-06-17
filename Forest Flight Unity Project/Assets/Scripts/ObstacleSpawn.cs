using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{

    //Declare variables and call objectPrefab

    public GameObject objectPrefab;
    public int spawnRate = 100;

    private int timer;

    // Update is called once per frame
    void FixedUpdate()
    {

        timer++;
        if(timer >= spawnRate)
        {

            //Instantiate spawns the object with range determining how high or low the obstacle can go.

            timer = 0;
            GameObject newObstacle = Instantiate(objectPrefab, new Vector2(objectPrefab.transform.position.x, objectPrefab.transform.position.y + Random.Range(-1.75f, 2.6f)), objectPrefab.transform.rotation);
            Destroy(newObstacle, 5f);

        }

    }
}
