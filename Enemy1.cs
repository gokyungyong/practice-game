using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Enemy
{
    void Start()
    {
        Move();
    }

    void Update()
    {
        
    }

    public virtual void Move()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * 50);
    }
}
