using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum state
{
    inFight,
    freeRoam,
    exit
}

public class Player : MonoBehaviour
{
    public float speed;
    public static state currentState;
    public static EnemyInFight currentEnemy;
    public Animator animator;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        currentState = state.freeRoam;
    }

    // Update is called once per frame
    void Update()
    {
        Walking();
    }


    private void Walking()
    {
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            rb.velocity = (-Command.Up + Command.Right) * speed;
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            rb.velocity = (-Command.Up - Command.Right) * speed;
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            rb.velocity = (Command.Up + Command.Right) * speed;
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            rb.velocity = (Command.Up - Command.Right) * speed;
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = -Command.Right * speed;
            animator.SetFloat("Horizontal", -1);
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("speed", 1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Command.Right * speed;
            animator.SetFloat("Horizontal", 1);
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("speed", 1);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = Command.Up * speed;
            animator.SetFloat("Vertical", 1);
            animator.SetFloat("Horizontal", 0);
            animator.SetFloat("speed", 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetFloat("Vertical", -1);
            animator.SetFloat("Horizontal", 0);
            animator.SetFloat("speed", 1);
            rb.velocity = -Command.Up * speed;
        }
        else
        {
            rb.velocity = Command.Stay;
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Horizontal", 0);
            animator.SetFloat("speed", 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            // Объект является противником
            currentState = state.inFight;
            currentEnemy = col.gameObject.GetComponent<EnemyInFight>();
            if (col.gameObject.GetComponent<EnemyInFight>().HealthStatus() == 0)
            {
                Destroy(col.gameObject);
                currentState = state.freeRoam;
            }
        }

        if (col.gameObject.CompareTag("Exit"))
        {
            ExitHandler.ExitTouched = true;
            LevelSystem.SetLevelStatus(MenuScript.CurrentScene);
        }
    }

    public static EnemyInFight GetObject()
    {
        return currentEnemy;
    }



    public static bool GetState()
    {
        return currentState == state.freeRoam;
    }

    public static void Fleed()
    {
        currentState = state.freeRoam;
    }
}

public class Command
{
    public static Vector2 Right = new Vector2(1,0);
    public static Vector2 Up = new Vector2(0,1);
    public static Vector2 Stay = new Vector2(0, 0);
}
