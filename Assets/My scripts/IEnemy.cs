using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HW_4.Factory
{
    public interface IEnemy
    {
        void Configure(EnemyData data);
        void Move();
    }
}
