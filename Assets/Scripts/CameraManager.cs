using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCamera;

    public Camera fightCamera;
    
    public Camera exit;

    void Start()
    {
        fightCamera.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
    }

    private void Update()
    {
        CameraUpdater();
    }

    public void CameraUpdater()
    {
        if (!Player.GetState())
            ToFight();
        else if (ExitHandler.ExitTouched)
            ToExit();
        else
        {
            ToFreeRoam();
            Player.Fleed();
        }
        
    }

    public void Flee()
    {
        ToFreeRoam();
    }

    private void ToFight()
    {
        mainCamera.gameObject.SetActive(false);
        fightCamera.gameObject.SetActive(true);
    }

    private void ToFreeRoam()
    {
        mainCamera.gameObject.SetActive(true);
        fightCamera.gameObject.SetActive(false);
    }

    public void ToExit()
    {
        mainCamera.gameObject.SetActive(false);
        exit.gameObject.SetActive(true);
    }
}
