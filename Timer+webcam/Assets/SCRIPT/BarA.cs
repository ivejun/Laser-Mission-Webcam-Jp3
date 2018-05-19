using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarA : MonoBehaviour {
    Image bar;
    private float max = 100f;
    public static float healthA;
    // Use this for initialization
    void Start()
    {
        bar = GetComponent<Image>();
        healthA = max;

    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = healthA / max;
    }
}
