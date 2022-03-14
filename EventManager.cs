using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action EnemyDieEvent;

    public static void RunEnemyDieEvent()
    {
        if (EnemyDieEvent != null)
        {
            EnemyDieEvent();
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
