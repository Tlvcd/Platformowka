using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpscript : MonoBehaviour
{
    public GameObject tppoint;
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = tppoint.transform.position;
    }

}
