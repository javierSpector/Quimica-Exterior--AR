using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transition : MonoBehaviour
{
   Animator anim;
    public int counter;
    public Text txt;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        counter = 0;
        EventsController.current.onSwipeLeft += Previous;
        EventsController.current.onSwipeRight += Next;
    }

    // Update is called once per frame
    public void Next() {
        counter++;
        if (counter > 6) {
            counter = 2;
        }

        switch (counter) {
            case 1:
                anim.Play("001_Quimica a Transferencia");
                txt.text = "Transferencia";
                break;
            case 2:
                anim.Play("002_Transferemcia a Grado");
                txt.text = "Grado";
                break;
            case 3:
                anim.Play("003_Grado a Reloj");
                txt.text = "Reloj";
                break;
            case 4:
                anim.Play("004_Reloj a Hospital");
                txt.text = "Hospital";
                break;
            case 5:
                anim.Play("005_Hospital a Quimica");
                txt.text = "Quimica";
                break;
            case 6:
                anim.Play("001_Quimica a Transferencia");
                txt.text = "Transferencia";
                break;
        }
    }

    private void Previous() {
        counter--;
        if (counter < 0) {
            counter = 4;
        }
        switch (counter) {
            case 0:
                anim.Play("001_Quimica a Transferencia R_");
                txt.text = "Quimica";
                break;
            case 1:
                anim.Play("002_Transferemcia a Grado R_");
                txt.text = "Transferencia";
                break;
            case 2:
                anim.Play("003_Grado a Reloj R_");
                txt.text = "Grado";
                
                break;
            case 3:
                anim.Play("004_Reloj a Hospital R_");
                txt.text = "Reloj";
              
                break;
            case 4:
                anim.Play("005_Hospital a Quimica R_");
                txt.text = "Hospital";
           
                break;
            case 5:
                anim.Play("001_Quimica a Transferencia R_");
                txt.text = "Quimica";
                break;
           
        }
    }
}
