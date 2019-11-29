using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickRV : MonoBehaviour
{
    public GameObject mostrar;
    private bool status;
    
    // Start is called before the first frame update
    void Start()
    {
        status = false;
        mostrar.SetActive(false);
    }

    void OnMouseDown()
    {
        status = true;
        mostrar.SetActive(true);
    }
}
