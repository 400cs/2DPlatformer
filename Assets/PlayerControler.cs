using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : PhysicsBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        desiredx = 0;
        if (Input.GetAxis("Horizontal") > 0) desiredx = 3;
        if (Input.GetAxis("Horizontal") < 0) desiredx = -3;

        if (Input.GetButton("Jump") && grounded) velocity.y = 6.5f;
    }

    public void Collide(Collider2D other)
    {
        if (other.gameObject.CompareTag("Lethal"))
        {
            Debug.Log("Ouch");
        }
    }

    public override void ColliderHorizontal(Collider2D other)
    {
        Collide(other);
    }

    public override void ColliderVertical(Collider2D other)
    {
        Collide(other);
    }

}
