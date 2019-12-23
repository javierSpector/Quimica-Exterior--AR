using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Video;

public class TransferenciaCanvas : MonoBehaviour, CanvasManager {
    
    //public string information;
    
    public GameObject transfPanel;
    public GameObject photoGaleryTransf;
    public GameObject closeButton;
    public GameObject goBackButton;
    public VideoPlayer videoPlayer;
    public GameObject information;
    

    private void Start() {
        gameObject.SetActive(false);
        transfPanel.SetActive(true);
        photoGaleryTransf.SetActive(false);
        goBackButton.SetActive(false);
        closeButton.SetActive(false);
        videoPlayer.enabled = false;
        information.SetActive(false);
    }

    public void ShowOptions() {
        Close();
        transfPanel.SetActive(true);
        closeButton.SetActive(true);

    }

    public void ShowInformation() {
        Close();
        information.SetActive(true);
        goBackButton.SetActive(true);
       

    }

    public void ShowPhotoGalery() {
        Close();
        photoGaleryTransf.SetActive(true);
        goBackButton.SetActive(true);


    }

    public void ShowVideo() {
        Close();
        goBackButton.SetActive(true);
      
        videoPlayer.enabled = true;
        videoPlayer.Play();
    }

    public void Close() {
        transfPanel.SetActive(false);
        photoGaleryTransf.SetActive(false);
        goBackButton.SetActive(false);
        closeButton.SetActive(false);
        videoPlayer.Stop();
        videoPlayer.enabled = false;
        information.SetActive(false);
    }
}
