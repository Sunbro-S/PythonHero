using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitHandler : MonoBehaviour
{
    public GameObject exit;

    public static bool ExitTouched;

    public int enemiesNeed;

    public void Start()
    {
        ExitTouched = false;
        exit.SetActive(false);
    }

    private void Update()
    {
        if (EnemyInFight.enemiesCounter == enemiesNeed) exit.SetActive(true);
    }
}
