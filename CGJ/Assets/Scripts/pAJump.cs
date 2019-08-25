using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player Advanced Jump
public class pAJump : MonoBehaviour {

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    private Rigidbody2D rb;

    void Awake() {

        rb = GetComponent<Rigidbody2D>();

    }

    void Update() {

        // If Falling; Apply Gravity Stuff
        if (rb.velocity.y < 0) {

            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;

        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.UpArrow)) {

            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;


        }

    }

}
