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
        public int EnemiesLeft;
        private static int enemiesCounter;
        public static bool enemiesIsDead = false;

        private void Awake()
        {
            currentHealth = maxHealth;
            enemiesCounter = EnemiesLeft;
        }
        

        private void Update()
        {
            if (IsDead())
            {
                enemiesCounter--;
                Destroy(gameObject);
            }

            if (enemiesCounter <= 0) enemiesIsDead = true;
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
