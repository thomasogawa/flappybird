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

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocity * Time.deltaTime;
    }
}
