/*Alan Lu & Thomas Ogawa
 * 2378209 & 2370770
 * allu@chapman.edu & togawa@chapman.edu
 * CPSC 245-01
 * Final Project
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float velocity = 2;
    private bool isPlaying;
	public int loopCount = 0;

    // Update is called once per frame
    void Awake()
    {
        StartCoroutine(MoveObstacle());
    }

	public void loop()
	{
		//idk make it so that it speeds up after each loop. I'll fix this later.......
		this.velocity += .1f;
		this.transform.position = new Vector2(loopCount+20, Random.Range(1.75f,-1.5f));
		loopCount++;
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ObstacleEdge")
        {
            loop();
        }
    }

    IEnumerator MoveObstacle()
    {
        isPlaying = true;
        while (isPlaying)
        {
            transform.position += Vector3.left * velocity * Time.deltaTime;
            yield return null;
        }
    }
}
