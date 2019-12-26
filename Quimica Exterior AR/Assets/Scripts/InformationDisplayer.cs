using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class InformationDisplayer : MonoBehaviour
{
    public GameObject canvas;
    private Swipe swipe;

    private void Start()
    {

        //canvas.SetActive(status);

//        closeImage.onClick.AddListener(closeCanvas);
        swipe = FindObjectOfType<Swipe>();
    }

    void OnMouseDown()
    {
        canvas.SetActive(true);
        swipe.gameObject.SetActive(false);
    }

    public void closeCanvas() {
    
        canvas.SetActive(false);
        swipe.gameObject.SetActive(true);
    }
}
