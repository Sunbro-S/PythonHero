using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public static Dictionary<string, bool> LevelFlags = new Dictionary<string, bool> ()
    {
        {"TutorialMap", false}, 
        {"Level1", false},
        {"Level2", false},
        {"Level3", false}
    };

    public void Update()
    {
        
    }

    public static void SetLevelStatus(string levelName) => LevelFlags[levelName] = true;
}
