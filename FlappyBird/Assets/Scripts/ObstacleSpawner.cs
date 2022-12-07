using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    public void SpawnObstacle()
    {
        Instantiate(ObstaclePrefab, new Vector2(19, Random.Range(1.5f,-1.5f)), Quaternion.identity);
    }
}
