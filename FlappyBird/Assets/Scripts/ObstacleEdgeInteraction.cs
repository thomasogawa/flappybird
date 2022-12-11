using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObstacleEdgeInteraction : MonoBehaviour
{
    public ObstacleMovement ObstacleMovement;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ObstacleEdge")
        {
            print("obstacle edge interaction");
            //ObstacleEdgeInteraction.Invoke();
        }
    }
}
