/*Alan Lu & Thomas Ogawa
 * 2378209 & 2370770
 * allu@chapman.edu & togawa@chapman.edu
 * CPSC 245-01
 * Final Project
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rigidBody;
    public float velocity;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    public void Flap()
    {
        rigidBody.velocity = Vector3.up * velocity;
    }
}
