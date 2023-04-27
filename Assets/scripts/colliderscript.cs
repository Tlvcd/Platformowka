using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderscript : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        other.transform.SetParent(transform, true);        
        print("collided");
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
        player.transform.localScale= new Vector3(1, 1, 1);
    }
}
