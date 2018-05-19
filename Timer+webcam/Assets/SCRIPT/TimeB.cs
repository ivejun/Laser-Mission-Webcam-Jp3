using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeB : MonoBehaviour {
    private int time = 0;
    public Text timer;
    public int lasttimeB = 0;
    void Start()
    {

    }

    public void StartTimer()
    {
        lasttimeB = 0;
        time = 0;
        InvokeRepeating("IncrimentTime", 1, 1);
    }

    public void StopTimer()
    {
        lasttimeB = time;
        CancelInvoke();
    }

    void IncrimentTime()
    {
        time += 1;
        timer.text = "" + time;
    }

    public void TambahB()
    {
        time += 5;
        timer.text = "" + time;
    }


}
