using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HW_4.Factory
{
    public enum EnemyType
    {
        SimpleEnemy,
        FastEnemy,
        TankEnemy

    }
    // tut u menya ne vihodit v Assets>Create> i net varianta "ScriptableObject" tozhe oshibka vihodit
    [CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/EnemyData", order = 1)]
    public class EnemyData : ScriptableObject
    {
        public EnemyType Type;
        public GameObject Prefab;
        public float MoveSpeed;
        public float Health;
        // zdec pri zapuske vidaet oshibku Waypoints ne naiden 
        // public GameObject[] Waypoints;
    }
}