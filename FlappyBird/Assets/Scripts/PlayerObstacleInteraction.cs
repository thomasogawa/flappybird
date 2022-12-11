using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerObstacleInteraction : MonoBehaviour
{
    public UnityEvent playerObstacleInteraction;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ObstacleSpace")
        {
            playerObstacleInteraction.Invoke();
        }
    }
}
