using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowMenu : MonoBehaviour
{
    public TPSCamera tps;
    public Canvas menu;
    public static bool isShowMenu;
    [Header("Camara secundaria:")]
    public GameObject cam;
    [Header("Planets:")]
    public GameObject[] planet;


    private void Start()
    {
        menu.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            isShowMenu = !isShowMenu;
            menu.gameObject.SetActive(isShowMenu);
            tps.isLock = isShowMenu;
        }

        if (OnClick.onMercury)
        {
            cam.transform.position = new Vector3(planet[0].transform.position.x,
                planet[0].transform.position.y,
                planet[0].transform.position.z - 10);
        }

        if (OnClick.onVenus)
        {
            cam.transform.position = new Vector3(planet[1].transform.position.x,
                planet[1].transform.position.y,
                planet[1].transform.position.z - 55);
        }

        if (OnClick.onEarth)
        {
            cam.transform.position = new Vector3(planet[2].transform.position.x,
                planet[2].transform.position.y, 
                planet[2].transform.position.z - 500);
        }

        if (OnClick.onMars)
        {
            cam.transform.position = new Vector3(planet[3].transform.position.x,
                planet[3].transform.position.y,
                planet[3].transform.position.z - 16);
        }

        if (OnClick.onJupiter)
        {
            cam.transform.position = new Vector3(planet[4].transform.position.x,
                planet[4].transform.position.y,
                planet[4].transform.position.z - 330);
        }

        if (OnClick.onSaturn)
        {
            cam.transform.position = new Vector3(planet[5].transform.position.x,
                planet[5].transform.position.y,
                planet[5].transform.position.z - 350);
        }

        if (OnClick.onUranus)
        {
            cam.transform.position = new Vector3(planet[6].transform.position.x,
                planet[6].transform.position.y,
                planet[6].transform.position.z - 120);
        }

        if (OnClick.onNeptune)
        {
            cam.transform.position = new Vector3(planet[7].transform.position.x,
                planet[7].transform.position.y,
                planet[7].transform.position.z - 116);
        }

        if (OnClick.onSun)
        {
            cam.transform.position = new Vector3(planet[8].transform.position.x,
                planet[8].transform.position.y,
                planet[8].transform.position.z - 1600);
        }

    }

    public void loadScene(string s)
    {
        SceneManager.LoadScene(s);
    }

}
