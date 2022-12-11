using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleEdgeInteraction : MonoBehaviour
{
    public ObstacleMovement ObstacleMovement;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ObstacleEdge")
        {
            print("obstacle edge interaction");
            //transform.position += Vector3.right * 45;
            //ObstacleMovement.velocity *= 2;
        }
    }
}
