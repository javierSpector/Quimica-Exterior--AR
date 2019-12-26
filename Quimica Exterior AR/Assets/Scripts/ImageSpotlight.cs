using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSpotlight : MonoBehaviour
{
    private Button imageTouch;
    private Texture texture;
    private GameObject imageSpotlight;

    private void Start() {
        imageTouch = GetComponent<Button>();
        imageTouch.onClick.AddListener(Spotlight);
        texture = GetComponent<RawImage>().texture;
    }

    private void Spotlight() {
        Destroy(imageSpotlight);
        imageSpotlight = Instantiate(Resources.Load("ImageSpotlight") as GameObject);
        imageSpotlight.transform.GetChild(0).GetChild(0).GetComponent<RawImage>().texture = texture;
        Destroy(imageSpotlight, 3);
       
    }

}
