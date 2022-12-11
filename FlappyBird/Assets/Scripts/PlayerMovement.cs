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
    public AudioClip FlapNoise;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        Flap();
    }

    public void Flap()
    {
        rigidBody.velocity = Vector3.up * velocity;
        SoundManager.Instance.PlayMusic(FlapNoise);
    }

    public void Reset()
    {
        print(transform.position);
        transform.position = new Vector3(0f, 1f, 0f);
        print(transform.position);
    }
}
