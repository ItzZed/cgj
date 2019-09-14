using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {

    void Start() {



    }

    void Update() {

        if(Input.GetKeyDown(KeyCode.R)) {

            loadLevel("Main");

        }

    }

    public void loadLevel(string levelName) {

        SceneManager.LoadScene(levelName);

    }

}
