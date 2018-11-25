using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D myBody;
    private float moveForce = 10f;


    // Use this for initialization
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        myBody.velocity = new Vector3(h * moveForce, 0f, 0f);
    }
} //class

