using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerEdgeInteraction : MonoBehaviour
{
    public UnityEvent playerEdgeInteraction;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerEdge")
        {
            playerEdgeInteraction.Invoke();
        }
    }
}
