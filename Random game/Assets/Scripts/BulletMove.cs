using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    private Rigidbody2D body;
    public float speed;
    Vector2 speedV2;

     void start()
    {
        speedV2 = new Vector2(speed, 0);
        body = GetComponent<Rigidbody2D>();
        addSpeed();
    }

    private void Update()
    {
        if(transform.position.y > 100)
        {
            gameObject.SetActive(false);
        }
    }

    void addSpeed()
    {
        body.AddRelativeForce(speedV2);
    }
}
