using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;
using System;

public class Communication : MonoBehaviour {

    public GameObject tambahA;
    public GameObject tambahB;

    public GameObject healtA;
    public GameObject healtB;

    public GameObject photoa;
    teamA teama;
    public GameObject photob;
    teamB teamb;

    private TimeA timeA;
    private TimeB timeB;

    bool startstate = false;
    int counter = 0;
    bool statestop = true;

    public Text winner;
    public Color merah;
    public Color hijau;
    SerialPort sp = new SerialPort("COM8", 9600);

    public AudioSource LaserA;
    public AudioSource LaserB;
    public AudioSource StartSong;
    public AudioSource Intro;
    public AudioSource Awinner;
    public AudioSource Bwinner;


    bool stopAAA = false;
    bool stopBBB = false;



    void Start () {

        teama = photoa.GetComponent<teamA>();
        teamb = photob.GetComponent<teamB>();


        timeA = tambahA.GetComponent<TimeA>();
        timeB = tambahB.GetComponent<TimeB>();


        try
        {
            sp.Open();

            Debug.Log("Connected");
        }
        catch(Exception e) {
            Debug.Log("Arduino Not Connected");
        }
        sp.ReadTimeout = 200;
	}
	
	void Update () {
        if (sp.IsOpen) {
            try
            {
                Move(sp.ReadByte());
            }
            catch (Exception e) {
                Debug.Log("Menunggu Data Masuk");
            }
        }
	}

    void Move(int data) {
        if (data == 7) {
            Intro.Play();
        }
        if (data == 1) {
            if (statestop)
            {
                HealtB.HealtBBB = 100f;
                BarB.healthB = 100f;
                HealtA.Healt = 100f;
                BarA.healthA = 100f;

                timeA.StartTimer();
                timeB.StartTimer();
                startstate = true;
                statestop = false;
                winner.text = "";
                StartSong.Play();
             }
        }
        if (startstate)
        {
            if (data == 2)
            {
                tambah5A();
            }
            if (data == 3)
            {
                tambah5B();
            }

            if (data == 4)
            {
                timeA.StopTimer();
                stopAAA = true;
            }
            if (data == 5)
            {
                timeB.StopTimer();
                stopBBB = true;
            }

            if (stopAAA == true && stopBBB == true) {

                stopAAA = false;
                stopBBB = false;
                startstate = false;
                counter = 0;
                statestop = true;
                Debug.Log("Masokkk");
                StartSong.Stop();
                if (timeA.lasttimeA < timeB.lasttimeB)
                {
                    teamb.RemovePhotoB();
                    winner.text = "WINNER\n IS TEAM A";
                    winner.fontSize = 50;
                    winner.color = hijau;
                    Awinner.Play();
                    
                }
                else {
                    teama.RemovePhotoA();
                    winner.text = "WINNER\n IS TEAM B";
                    winner.fontSize = 50;
                    winner.color = merah;
                    Bwinner.Play();
                }
            }
        }
    }

    void tambah5A()
    {
        HealtA.Healt -= 5;
        BarA.healthA -= 5;
        timeA.TambahA();
        LaserA.Play();
    }

    void tambah5B()
    {
        HealtB.HealtBBB -= 5;
        BarB.healthB -= 5;
        timeB.TambahB();
        LaserB.Play();
    }
}
