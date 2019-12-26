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

        transfPanel.SetActive(true);
        photoGaleryTransf.SetActive(false);
        goBackButton.SetActive(false);
        closeButton.SetActive(true);
        videoPlayer.enabled = false;
        information.SetActive(false);
    }

    public void ShowOptions() {
        closeCommon();
        transfPanel.SetActive(true);
        closeButton.SetActive(true);

    }

    public void ShowInformation() {
        closeCommon();
        information.SetActive(true);
        goBackButton.SetActive(true);
       

    }

    public void ShowPhotoGalery() {
        closeCommon();
        photoGaleryTransf.SetActive(true);
        goBackButton.SetActive(true);


    }

    public void ShowVideo() {
        closeCommon();
        goBackButton.SetActive(true);
      
        videoPlayer.enabled = true;
        videoPlayer.Play();
    }

    public void Close() {
        closeCommon();
        transfPanel.SetActive(true);
        gameObject.SetActive(false);
    }

    private void closeCommon()
    {
        transfPanel.SetActive(false);
        photoGaleryTransf.SetActive(false);
        goBackButton.SetActive(false);
        closeButton.SetActive(false);
        videoPlayer.Stop();
        videoPlayer.enabled = false;
        information.SetActive(false);
    }
}
