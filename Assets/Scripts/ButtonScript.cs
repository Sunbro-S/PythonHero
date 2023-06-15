using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Canvas dicisionsCanvas;

    public Canvas quizCanvas;
    
    public GameObject vpr;

    public Image th;

    public Text t;

    public FightHandler task;
    
    public void Check()
    {
        if (t.text == task.True)
        {
            if (!Player.GetObject().IsDead())
            {
                ChangeCanvasToDicison();
                Player.GetObject().TakeDamage(100);
            }
            if (Player.GetObject().IsDead())
                Player.Fleed();
        }
        else
        {
            //Player.TakeDamage();
            //Todo: анимация урона
            ChangeCanvasToDicison();
        }
    }

    private void ChangeCanvasToDicison()
        {
            quizCanvas.gameObject.SetActive(false);
            dicisionsCanvas.gameObject.SetActive(true);
        }
}
