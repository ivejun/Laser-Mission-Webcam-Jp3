using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;

public class photo : MonoBehaviour {
    

    public static int counter = 0;
    bool startcam = true;
    public string deviceName;
    WebCamTexture wct;
    bool counterbool = false;
    // Use this for initialization
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        deviceName = devices[0].name;
        wct = new WebCamTexture(deviceName, 400, 300, 12);
        GetComponent<Renderer>().material.mainTexture = wct;
        wct.Play();
    }

    // For photo varibles
    public Texture2D heightmap;
    public Vector3 size = new Vector3(100, 10, 100);



    public void takephotoA() {
        TakeSnapshot();
        counterbool = true;
    }

    public void takephotoB()
    {
        TakeSnapshot();
        counterbool = true;
    }

    public void stopcam() {
        wct.Stop();
    }

    public void startcams(){
            wct.Play();
    }

    // For saving to the _savepath
    private string _SavePath = "C:/GG/"; //Change the path here!
    int _CaptureCounter = 0;

    void TakeSnapshot()
    {
        Texture2D snap = new Texture2D(wct.width, wct.height);
        snap.SetPixels(wct.GetPixels());
        snap.Apply();

        System.IO.File.WriteAllBytes(_SavePath + _CaptureCounter.ToString() + ".png", snap.EncodeToPNG());
        ++_CaptureCounter;
    }

    private void Update()
    {
        if (counterbool) {
        counter += 1;
            counterbool = false;
        }
    }
}