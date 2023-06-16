using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class EnemyInFight : MonoBehaviour
{
        public int maxHealth = 100;
        private int currentHealth;
        public static int enemiesCounter;


        private void Awake()
        {
            currentHealth = maxHealth;
            enemiesCounter = 0;

        }
        

        private void Update()
        {
            if (IsDead())
            {
                enemiesCounter++;
                Destroy(gameObject);
            }
            
        }



        public int HealthStatus()
        {
            return currentHealth;
        }
    
        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                currentHealth = 0;
            }
        }
    
        public bool IsDead()
        {
            return currentHealth == 0;
        }

        public void RestoreHealth()
        {
            currentHealth = 100;
        }
}
