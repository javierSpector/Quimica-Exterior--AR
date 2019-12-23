using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TransferenciaCanvas : MonoBehaviour, CanvasManager {
    
    //public string information;
    
    public GameObject canvasTransf;
    public GameObject canvasPhotoGaleryTransf;
    public GameObject closeButton;
    public GameObject goBackButton;
    

    private void Start() {
        canvasTransf.SetActive(false);
        canvasPhotoGaleryTransf.SetActive(false);
        goBackButton.SetActive(false);
        closeButton.SetActive(false);
    }

    public void ShowOptions() {
        canvasTransf.SetActive(true);
        canvasPhotoGaleryTransf.SetActive(false);
        goBackButton.SetActive(false);
        closeButton.SetActive(true);

    }

    public void ShowInformation() {
        goBackButton.SetActive(true);
        closeButton.SetActive(false);

    }

    public void ShowPhotoGalery() {
        canvasTransf.SetActive(false);
        canvasPhotoGaleryTransf.SetActive(true);
        goBackButton.SetActive(true);
        closeButton.SetActive(false);


    }

    public void ShowVideo() {
        goBackButton.SetActive(true);
        closeButton.SetActive(false);


    }

    public void Close() {
        canvasTransf.SetActive(false);
        canvasPhotoGaleryTransf.SetActive(false);
        goBackButton.SetActive(false);

    }
}
