using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HW_4.Factory
{
    public class SimpleEnemy : Enemy
    {
        public override void Move()
        {
            // tak kak fabrika u menya ne rabotaet, I proveryala sam spawn enemy 
            Debug.Log("SimpleEnemy Move");
        }
    }
}
