using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitHandler : MonoBehaviour
{
    public GameObject exit;

    public static bool ExitTouched = false;
    
    public void Start() => exit.SetActive(false);

    private void Update()
    {
        var flag = EnemyInFight.enemiesIsDead;
        if (flag) exit.SetActive(true);
    }
}
