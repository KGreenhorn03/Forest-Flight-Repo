using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{

    public GameObject objectPrefab;
    public int spawnRate = 100;

    private int timer;

    // Update is called once per frame
    void FixedUpdate()
    {

        timer++;
        if(timer >= spawnRate)
        {

            timer = 0;
            GameObject newObstacle = Instantiate(objectPrefab, new Vector2(objectPrefab.transform.position.x, objectPrefab.transform.position.y + Random.Range(-1.75f, 2.6f)), objectPrefab.transform.rotation);
            Destroy(newObstacle, 5f);


        }

    }
}
