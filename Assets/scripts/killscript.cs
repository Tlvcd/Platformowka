using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killscript : MonoBehaviour
{
    public GameObject player;
    public GameObject playerbody;
    public GameObject killscreen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player.gameObject)
        {
            killscreen.gameObject.SetActive(true);
            playerbody.gameObject.SetActive(false);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }    
    }
}
