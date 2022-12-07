using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ObstacleSpawner ObstacleSpawner;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 1)
        {
            ObstacleSpawner.SpawnObstacle();
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
