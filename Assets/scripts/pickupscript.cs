using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupscript : MonoBehaviour
{
    public PlayerMovementScript doublej;
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        doublej.doublejumpenabled = true;
        gameObject.SetActive(false);
    }
}
