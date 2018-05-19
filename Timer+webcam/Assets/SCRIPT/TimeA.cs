using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeA : MonoBehaviour
{
    public int time = 0;
    public Text timer;
    public int lasttimeA = 0;
    void Start()
    {

    }
    void Update()
    {
    }

    public void StartTimer()
    {
        lasttimeA = 0;
        time = 0;
        InvokeRepeating("IncrimentTime", 1, 1);
    }

    public void StopTimer()
    {
        lasttimeA = time;
        CancelInvoke();
    }

    void IncrimentTime()
    {
        time += 1;
        timer.text = "" + time;
    }

    public void TambahA() {
        time += 5;
        timer.text = "" + time;
    }
}