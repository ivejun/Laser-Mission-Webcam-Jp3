using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable : MonoBehaviour {

    public GameObject Foto;
    public GameObject Waktu;
    bool disable = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void done() {
        Foto.SetActive(false);

        Waktu.SetActive(true);
    }

    public void ambilfoto()
    {
        Foto.SetActive(true);

        Waktu.SetActive(false);
    }
}
