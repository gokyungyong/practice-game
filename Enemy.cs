using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float health = 50.0f;

    void Start()
    {
        Debug.Log("health : " + health);
    }

    void TakeDamage(int value)
    {
        health -= value;
        if ( health <= 0)
        {
            Die();
        }
    }

    public float Health
    {
        get {return health;}
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(10);
            //Debug.Log("health : " + health);
            coll.gameObject.SetActive(false);
        }
    }

    void Die()
    {
        EventManager.RunEnemyDieEvent();
        Destroy(this.gameObject);
    }

    public virtual void Move()
    {
        
    }

}
