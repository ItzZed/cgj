using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerIndicator : MonoBehaviour {

    public Text indicator;
    public realityPower rP;
    

    void Start() {

        indicator = GetComponent<Text>();
        
    }

    void Update() {

        if(rP.powerOn == true) {

            indicator.text = "On";

        }
        else if (rP.powerOn == false)
        {

            indicator.text = "Off";

        }
        else {

            // If Displayed Something's Wrong
            indicator.text = "powerIndicator String Error";

        }

    }
}
