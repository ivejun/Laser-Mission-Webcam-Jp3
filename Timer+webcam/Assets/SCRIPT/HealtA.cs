using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtA : MonoBehaviour {

    public Text HealtAA;
    public static float Healt = 100f;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        HealtAA.text = "" + Healt;
        if (Healt <= 0) {
            HealtAA.fontSize = 35;
            HealtAA.text = "Game Over";
        }
    }
}
