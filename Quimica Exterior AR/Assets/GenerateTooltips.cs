using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GenerateTooltips : MonoBehaviour
{

    [FormerlySerializedAs("startPos")] public Transform startPlane;

    private LineRenderer _lineRenderer;
    public Material sphereMaterial;

    private float width = 0.1f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.startWidth = _lineRenderer.endWidth = width;
       

        //_lineRenderer.material = startPlane.gameObject.GetComponent<Renderer>().material;
    }

   
}
