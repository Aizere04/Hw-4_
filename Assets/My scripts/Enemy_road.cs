using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HW_4.Factory
{
    public class Enemy_road : MonoBehaviour
    {
        public GameObject[] waypoints;

        
        public GameObject[] enemyPrefabs;

        void Start()
        {
            
            int randomEnemyIndex = Random.Range(0, enemyPrefabs.Length);
            GameObject selectedEnemyPrefab = enemyPrefabs[randomEnemyIndex];

            
            GameObject enemyObject = Instantiate(selectedEnemyPrefab);
            // v etom momente u menya vidaet mnogo oshibok, ne ponyala v chem error
            // Enemy component and configure it
            Enemy enemyComponent = enemyObject.GetComponent<Enemy>();

            if (enemyComponent != null)
            {
                // enemyComponent.Configure(waypoints);
                // Optionally call the Move method here if needed
                // enemyComponent.Move();
            }
            else
            {
                Debug.LogError("The instantiated enemy prefab does not have an Enemy component.");
            }
        }

        void Update()
        {
            
        }
    }
}
