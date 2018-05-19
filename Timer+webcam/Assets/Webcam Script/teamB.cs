using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teamB : MonoBehaviour {
    int counter = 0;
    // Use this for initialization
    public string url = "file://C:/GG/0.png";
    public GameObject Foto;


    public void TakePhotoB() {

        counter = photo.counter;

        url = "file://C:/GG/" + counter.ToString() + ".png";
        StartCoroutine(loadSpriteIMG(0.1f));

    }

    public void RemovePhotoB()
    {
        url = "file://C:/GG/a.png";
        StartCoroutine(loadSpriteIMG(0.1f));
    }

    IEnumerator loadSpriteIMG(float waitTime)
    {
        var www = new WWW(url);
        yield return www;
        Debug.Log("Succes");

        Texture2D texture = new Texture2D(1, 1);
        www.LoadImageIntoTexture(texture);
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0,
            texture.width, texture.height), Vector2.one / 2);

        GetComponent<SpriteRenderer>().sprite = sprite;
    }

}
