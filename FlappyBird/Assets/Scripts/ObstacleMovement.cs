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
    public float velocity;
    private bool isPlaying;

    // Update is called once per frame
    void Awake()
    {
        StartCoroutine(MoveObstacle());
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
