using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class InformationDisplayer : MonoBehaviour
{
    public GameObject canvas;
    public Button closeImage;
    private Swipe swipe;
    
    private bool status;
    private void Start()
    {
        status = false;
        canvas.SetActive(status);

        closeImage.onClick.AddListener(closeCanvas);
        swipe = FindObjectOfType<Swipe>();
    }

    void OnMouseDown()
    {
        if (status) return;
        status = true;
        swipe.gameObject.SetActive(!status);
        canvas.SetActive(status);
        
    }

    private void closeCanvas() {
        status = false;
        canvas.SetActive(false);
        swipe.gameObject.SetActive(!status);
    }
}
