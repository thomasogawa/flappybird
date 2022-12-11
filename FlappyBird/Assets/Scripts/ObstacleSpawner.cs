using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    private bool isSpawning;
    private int objectsSpawned = 0;
	private GameObject newObstacle;
	public GameObject[] ObstaclesArr;
    public void SpawnMultipleObstacles()
    {
        if (!isSpawning)
        {
            StartCoroutine(SpawnObstacles());
        }
    }

    public void PauseSpawning()
    {
        StopCoroutine(SpawnObstacles());
        isSpawning = false;
    }
    
    private GameObject SpawnObstacle()
    {
        newObstacle = Instantiate(ObstaclePrefab, new Vector2(19, Random.Range(1.75f,-1.5f)), Quaternion.identity);
		return newObstacle;
    }

    IEnumerator SpawnObstacles()
    {
        isSpawning = true;
        while (isSpawning && objectsSpawned < 15)
        {
			ObstaclesArr[objectsSpawned] = SpawnObstacle();
            objectsSpawned++;
            yield return new WaitForSeconds(1.0f);
        }
    }
	    
	public void Destroy()
    {
		while(objectsSpawned >0)
		{
			objectsSpawned--;
			Destroy(ObstaclesArr[objectsSpawned]);
		}
    }
}
