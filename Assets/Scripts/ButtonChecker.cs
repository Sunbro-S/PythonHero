using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChecker : MonoBehaviour
{
    public Button Button;
    public string LevelName;
    
    public void Update()
    {
        Button.interactable = LevelSystem.LevelFlags[LevelName];
    }
}
