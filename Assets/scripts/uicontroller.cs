using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class uicontroller : MonoBehaviour
{
    public GameObject Panel;
    public GameObject winscreen;
    public GameObject button_continue;
    public CharacterController character;
    public GameObject spawn;
    public GameObject MainMenu;
    public GameObject killscreen;
    public MouseLook mouselook;
    public InputField senschange;
    public void sensad()
    {
        mouselook.mouseSensitivity = float.Parse(senschange.text);
    }
    public void TPtoSpawn()
    {
        character.transform.position = spawn.transform.position;
    }
    public void tryagain()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void hideMainMenu()
    {
        MainMenu.gameObject.SetActive(false);
    }
    public void togglePause()
    {
        if (Panel.gameObject.activeInHierarchy == false)
        {
            Panel.gameObject.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Panel.gameObject.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
    public void Start()
    {
            Panel.gameObject.SetActive(false);
            winscreen.gameObject.SetActive(false);
            MainMenu.gameObject.SetActive(true);
            killscreen.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            togglePause();
        }
    }
}
