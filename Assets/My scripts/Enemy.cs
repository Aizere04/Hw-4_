using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HW_4.Factory
{
    public abstract class Enemy : MonoBehaviour, IEnemy
    {
        protected GameObject[] waypoints;
        protected int currentWaypoint = 0;
        protected float lastWaypointSwitchTime;
        public float rotationSpeed = 5.0f;
        public float speed = 1.0f;

        public virtual void Configure(EnemyData data)
        {
            if (data != null)
            {
                waypoints = data.Waypoints;
                lastWaypointSwitchTime = Time.time;
            }
            else
            {
               // Debug.LogError("EnemyData is null. Configuration failed.");
            }
        }


        public abstract void Move();

        protected void RotateIntoMoveDirection()
        {
            Vector3 newStartPosition = waypoints[currentWaypoint].transform.position;
            Vector3 newEndPosition = waypoints[currentWaypoint + 1].transform.position;
            Vector3 newDirection = (newEndPosition - newStartPosition);
            float x = newDirection.x;
            float y = newDirection.y;
            float rotationAngle = Mathf.Atan2(y, x) * 180 / Mathf.PI;
            GameObject sprite = gameObject.transform.Find("Sprite").gameObject;
            sprite.transform.rotation = Quaternion.AngleAxis(rotationAngle, Vector3.forward);
        }
    }
}
