using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoatScript : MonoBehaviour {

    public GameObject sprite;

    public static Vector2 lastPosition;
    public static bool firstPass = true;
    public float speed;

    private Rigidbody2D rb;

    float torqueForce = -0.5f;
    float driftFactor = 0.9f; 
  

    void Start() {
    
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<GameObject>();


        if (!firstPass)
            transform.position = lastPosition;
       
       firstPass = false;

    }


    void SetTransformX(float n){
        transform.position = new Vector2(n, transform.position.y);
    }

    void SetTransformY(float n){
        transform.position = new Vector2(transform.position.x, n);
    }


    void FixedUpdate() {

        //Store the current horizontal input in the float moveHorizontal.
        float turn = Input.GetAxis ("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float accelerate = Input.GetAxis ("Vertical");

        rb.AddTorque(torqueForce * turn); // ASK AQIL

        rb.AddForce(transform.up * speed * accelerate);

        rb.velocity = forwardVelocity() + rightVelocity()*driftFactor;

        lastPosition.x = transform.position.x;
        lastPosition.y = transform.position.y;      
    }

    Vector2 forwardVelocity() {
        return transform.up * Vector2.Dot(rb.velocity, transform.up);
    }

    Vector2 rightVelocity() {
        return transform.forward * Vector2.Dot(rb.velocity, transform.forward);
    }


}