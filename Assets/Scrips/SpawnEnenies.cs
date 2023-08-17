using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnenies : MonoBehaviour
{
    SpawnEnemy enemy;
     
    void Start()
    {
        enemy =  Instantiate(enemy, enemy.transform, enemy.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
