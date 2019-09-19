using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    public float speed;
    public float jumpForce;

    private Rigidbody2D rb;

    void Start() {

        rb = GetComponent<Rigidbody2D>();

    }

    void Update() {
        
    }

}
