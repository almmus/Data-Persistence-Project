using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : Brick 
{
    [SerializeField] private GameObject powerUpBall;
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject, 0.2f);
        Instantiate(powerUpBall, gameObject.transform.position, powerUpBall.transform.rotation);
    }
    
}
