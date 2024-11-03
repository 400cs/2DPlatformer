using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : PhysicsBase
{
    // Start is called before the first frame update
    void Start()
    {
        desiredx = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void ColliderHorizontal(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Ouch");
        }
        desiredx = -desiredx;
    }
}
