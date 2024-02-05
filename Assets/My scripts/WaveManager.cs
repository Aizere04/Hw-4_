using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace HW_4.Factory
{
    public class WaveManager : MonoBehaviour
    {
        [SerializeField] private List<WaveSettings> waveSettings = new List<WaveSettings>();
        private List<IEnemy> enemies = new List<IEnemy>();

        [Serializable]
        public class WaveSettings
        {
            public int EnemyCount;
            public float WaveDelay;
            public float CostPerUnit;
            public EnemyData EnemyData;
        }

        void Start()
        {
            // tut i pytalas sdelat neskolko waves of enemy(ne poluchilos)
            CreateWave(waveSettings[0]);
        }

        public void CreateWave(WaveSettings waveSettings)
        {
            StartCoroutine(SpawnEnemies(waveSettings));
        }

        // po moei logike "Coroutine" to spawn enemies dolzhen bil rabotat
        private IEnumerator SpawnEnemies(WaveSettings waveSettings)
        {
            //EnemyFactory<IEnemy> enemyFactory = new EnemyFactory<IEnemy>();

           // for (int i = 0; i < waveSettings.EnemyCount; i++)
            {
               // IEnemy enemy = enemyFactory.CreateEnemy(waveSettings.EnemyData);
                //enemies.Add(enemy);

                // Optionally call the Move method here if needed
               // enemy.Move();

                // Add delay logic here if needed
                yield return new WaitForSeconds(waveSettings.WaveDelay);
            }
        }
    }
}



