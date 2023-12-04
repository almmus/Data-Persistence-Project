using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBall : Ball
{
    private Rigidbody m_Rigidbody1;
    [SerializeField] private GameObject brickPrefab;      
    [SerializeField] private float speed = 4.0f;

    void Start()
    {
        m_Rigidbody1 = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject, 0.2f);
    }
    
    private void OnCollisionExit(Collision other)
    {
        var velocity = m_Rigidbody1.velocity;

        //after a collision we accelerate a bit
        velocity += velocity.normalized * 0.05f;

        //check if we are not going totally vertically as this would lead to being stuck, we add a little vertical force
        if (Vector3.Dot(velocity.normalized, Vector3.up) < 0.5f)
        {
            velocity += velocity.y > 0 ? Vector3.up * 1f : Vector3.down * 1f;
        }

        //max velocity
        if (velocity.magnitude > 6.0f)
        {
            velocity = velocity.normalized * 6.0f;
        }

        m_Rigidbody1.velocity = velocity;
    }
    

}
