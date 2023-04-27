using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winscript : MonoBehaviour
{
    public GameObject player;
    public GameObject winscreen;
    private void OnTriggerEnter(Collider other)
    {
        //player.transform.position = new Vector3(5, 2, 2);
        if (other.gameObject == player.gameObject)
        {
            winscreen.gameObject.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
        
    }
}

