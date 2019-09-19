using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realityPower : MonoBehaviour {

    public bool powerOn;

    void Start() {


        
    }

    void Update() { 

        if(Input.GetKey(KeyCode.Space)) {

            powerOn = true;

        }
        else {

            powerOn = false;

        }
        
    }
}
