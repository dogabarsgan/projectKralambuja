using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

	public Animator animator;
    public CharacterController2D controller;

    public static bool moveSpikes;
    public static bool moveSpikes2;
    public static bool moveSpikes3;
    public static bool moveSpikes4;
    public static bool moveSpikes5;

    public static bool showCoin;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;


    // Update is called once per frame
    void Update() {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump")) {
            FindObjectOfType<AudioManager>().Play("Jump");
            jump = true;
			animator.SetBool("isJumping", true);
        }
    }

    public void OnLanding() {
        animator.SetBool("isJumping", false);
        jump = false;
    }


    void FixedUpdate() {

        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        
    }

    void OnTriggerEnter2D(UnityEngine.Collider2D c) {

        if (c.gameObject.name == "bronze_coin") {
            showCoin = true;
        }
        
        if (c.gameObject.tag == "Spikes") {
            FindObjectOfType<AudioManager>().Play("Ouch");
            HealthBarScript.health -= 10;
            if (c.gameObject.name == "Spikes")
                moveSpikes = true;
            else if (c.gameObject.name == "Spikes (1)")
                moveSpikes2 = true;
            else if (c.gameObject.name == "Spikes (2)")
                moveSpikes3 = true;
            else if (c.gameObject.name == "Spikes (3)")
                moveSpikes4 = true;
            else if (c.gameObject.name == "Spikes (4)")
                moveSpikes5 = true;
            if (HealthBarScript.health <= 0) {
                isDying();
            }
            animator.SetBool("beingHit", true);
        }
    }
    
    void OnTriggerStay2D(UnityEngine.Collider2D c) {
        moveSpikes = false;
    }

    void OnTriggerExit2D(UnityEngine.Collider2D c) {
        animator.SetBool("beingHit", false);
        moveSpikes = false;
    }

    void isDying() {
        animator.SetBool("hasDied", true);
    }
}
