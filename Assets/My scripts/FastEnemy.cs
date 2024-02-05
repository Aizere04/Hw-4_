using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HW_4.Factory
{
    public class FastEnemy : Enemy
    {
        public override void Move()
        {
            // tak kak fabrika u menya ne rabotaet, I proveryala sam spawn enemy 
            Debug.Log("FastEnemy Move");
        }
    }
}