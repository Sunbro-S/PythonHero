using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

public class EnemiesList : MonoBehaviour
{
    public List<Object> Enemies;
    private static List<Object> enemiesList;

    public void Start()
    {
        enemiesList = Enemies;
    }

    public void Update()
    {
        Enemies = enemiesList;
    }

    public static void Delete(Object enemy)
    {
        enemiesList.Remove(enemy);
    }
    public static int GetCount()
    {
        return enemiesList.Count;
    }

}
