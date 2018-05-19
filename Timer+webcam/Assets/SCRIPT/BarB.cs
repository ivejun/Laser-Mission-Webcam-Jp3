using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarB : MonoBehaviour {
    Image bar;
    private float max = 100f;
    public static float healthB;
    // Use this for initialization
    void Start()
    {
        bar = GetComponent<Image>();
        healthB = max;
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = healthB / max;
    }
}
