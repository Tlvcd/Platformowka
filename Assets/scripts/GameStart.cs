using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    public CharacterController gracz;
    public GameObject spawn;
    public GameObject testlevel;
    public GameObject menucamera;
    public GameObject debuglevel;
    public GameObject poziom1;
    public GameObject lv1spawn;
    public GameObject lv2spawn;
    public GameObject poziom2;
    public GameObject testlv;
    public int currentlvl;
    public GameObject rigidbodylv2;
    public GameObject rigidbodyspawnlv2;
    public GameObject coinlv2;
    public PlayerMovementScript doublej;
    public Text currframe;
    
    public void quitgame()
    {
        Application.Quit();
    }
    public void refreshLv2()
    {
        doublej.doublejumpenabled = false;
        coinlv2.gameObject.SetActive(true);
        rigidbodylv2.transform.position = rigidbodyspawnlv2.transform.position;
        rigidbodylv2.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    public void framelimiter(float frames)
    {
        currframe.text = frames.ToString();
        Application.targetFrameRate = (int)frames;
    }
    public void respawnToCurrentlvl()
    {
        switch (currentlvl)
        {
            case 0:
                gracz.transform.position = testlv.transform.position;

                break;
            case 1:
                gracz.transform.position = lv1spawn.transform.position;
                break;
            case 2:
                refreshLv2();
                gracz.transform.position = lv2spawn.transform.position;
                
                break;
        }
    }
    public void debuglvl()
    {
        menucamera.gameObject.SetActive(false);
        gracz.gameObject.SetActive(true);
        debuglevel.gameObject.SetActive(true);
    }
    public void testlvl()
    {
        menucamera.gameObject.SetActive(false);
        gracz.gameObject.SetActive(true);
        testlevel.gameObject.SetActive(true);
        gracz.transform.position = testlv.transform.position;
        currentlvl = 0;

    }
    public void lvl1()
    {
        poziom1.gameObject.SetActive(true);
        gracz.gameObject.SetActive(true);
        gracz.transform.position = lv1spawn.transform.position;
        menucamera.gameObject.SetActive(false);
        currentlvl = 1;
        doublej.doublejumpenabled = false;
    }
    public void lvl2()
    {
        poziom2.gameObject.SetActive(true);
        currentlvl = 2;
        gracz.transform.position = lv2spawn.transform.position;
        menucamera.gameObject.SetActive(false);
        gracz.gameObject.SetActive(true);
        refreshLv2();
    }
     public void Start()
    {
        Application.targetFrameRate = 144;
        menucamera.gameObject.SetActive(true);
        gracz.gameObject.SetActive(false);
        testlevel.gameObject.SetActive(false);
        debuglevel.gameObject.SetActive(false);
        poziom1.gameObject.SetActive(false);
        poziom2.gameObject.SetActive(false);


    }
    public void removepause()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
