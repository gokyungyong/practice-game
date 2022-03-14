using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulet : MonoBehaviour
{
    void Start()
    {
        Invoke("DestorySelf", 2.0f);
    }

     void DestorySelf()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        
    }
}
