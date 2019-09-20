using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realityGround : MonoBehaviour {

    public GameObject[] rGround;
    public realityPower rP;

    void Start() {
        
    }

    void Update() {
        
        if(rP.powerOn == true) {

            foreach (GameObject g in rGround) {

                g.SetActive(true);
                
            }

        }
        else {

            foreach (var g in rGround) {

                g.SetActive(false);
                
            }

        }

    }
}
