using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place_monster : MonoBehaviour
{
    public GameObject monsterPrefab;
    private GameObject monster;

    //if place is null(pustoi) we can place the monster(turette)
    private bool CanPlaceMonster()
    {
        return monster == null;
    }

   
    void OnMouseUp()
    {
       
        if (CanPlaceMonster())
        {
            monster = (GameObject)
              Instantiate(monsterPrefab, transform.position, Quaternion.identity);
        }
    }
}