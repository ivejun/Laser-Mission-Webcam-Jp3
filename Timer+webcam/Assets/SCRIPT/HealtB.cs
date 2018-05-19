using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtB : MonoBehaviour
{

    public Text HealtBB;
    public static float HealtBBB = 100f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HealtBB.text = "" + HealtBBB;
        if (HealtBBB <= 0)
        {
            HealtBB.fontSize = 35;
            HealtBB.text = "Game Over";
        }
    }
}
