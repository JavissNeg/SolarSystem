using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{

    public Canvas canvas;
    public TPSCamera tps;
    [Header("Camaras:")]
    public GameObject[] cams;
    public ShowMenu solarSystem;
    public static bool onMercury;
    public static bool onVenus;
    public static bool onEarth;
    public static bool onMars;
    public static bool onJupiter;
    public static bool onSaturn;
    public static bool onUranus;
    public static bool onNeptune;
    public static bool onSun;

    public void ActionSun()
    {
        QuitMenu();
        PutSecondCam();
        OnDefault();
        DesactiveTrail();
        onSun = true;
    }

    public void ActionMercury()
    {
        QuitMenu();
        PutSecondCam();
        OnDefault();
        DesactiveTrail();
        onMercury= true;
    }

    public void ActionVenus()
    {
        QuitMenu();
        PutSecondCam();
        OnDefault();
        DesactiveTrail();
        onVenus = true;
    }

    public void ActionEarth()
    {
        QuitMenu();
        PutSecondCam();
        OnDefault();
        DesactiveTrail();
        onEarth = true;
    }

    public void ActionMars()
    {
        QuitMenu();
        PutSecondCam();
        OnDefault();
        DesactiveTrail();
        onMars = true;
    }

    public void ActionJupiter()
    {
        QuitMenu();
        PutSecondCam();
        OnDefault();
        DesactiveTrail();
        onJupiter = true;
    }

    public void ActionSaturn()
    {
        QuitMenu();
        PutSecondCam();
        OnDefault();
        DesactiveTrail();
        onSaturn = true;
    }

    public void ActionUranus()
    {
        QuitMenu();
        PutSecondCam();
        OnDefault();
        DesactiveTrail();
        onUranus = true;
    }

    public void ActionNeptune()
    {
        QuitMenu();
        PutSecondCam();
        OnDefault();
        DesactiveTrail();
        onNeptune = true;
    }


    public void ActionDefault()
    {
        QuitMenu();
        OnDefault();
        PutPrincipalCam();      
        ActiveTrail();
    }

    //----------------------------

    public void QuitMenu()
    {
        canvas.gameObject.SetActive(false);
        ShowMenu.isShowMenu = false;
        tps.isLock = false;
    }

    public void PutPrincipalCam()
    {
        cams[0].gameObject.SetActive(true);
        cams[1].gameObject.SetActive(false);
    }

    public void PutSecondCam()
    {
        cams[0].gameObject.SetActive(false);
        cams[1].gameObject.SetActive(true);
    }

    public void OnDefault()
    {
        onSun = true;
        onMercury = false;
        onVenus = false;
        onEarth = false;
        onMars = false;
        onJupiter = false;
        onSaturn = false;
        onUranus = false;
        onNeptune = false;
    }

    public void ActiveTrail()
    {
        for (int i = 0; i < solarSystem.planet.Length-1; i++)
        {
            solarSystem.planet[i].GetComponent<TrailRenderer>().enabled = true;
            solarSystem.planet[i].GetComponent <TrailRenderer>().Clear();
        }
    }

    public void DesactiveTrail()
    {
        for (int i = 0; i < solarSystem.planet.Length-1; i++)
        {
            solarSystem.planet[i].GetComponent<TrailRenderer>().enabled = false;
        }
    }
}
