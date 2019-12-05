using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonTransition : MonoBehaviour
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
    public void Next()
    {
        counter++;
        if (counter>6)
        {
            counter = 2;
        }
        switch (counter)
        { /*case 0:
                anim.SetInteger("animationTransition", counter);
//                anim.Play("animationTransition");
                txt.text = "Quimica";
                break;*/
            case 1:
                anim.SetInteger("animationTransition", counter);
                anim.SetInteger("animationReverse", counter);

                txt.text = "Transferencia";
                break;
            case 2:
                anim.SetInteger("animationTransition", counter);
                anim.SetInteger("animationReverse", counter);

                txt.text = "Grado";
                break;
            case 3:
                anim.SetInteger("animationTransition", counter);
                anim.SetInteger("animationReverse", counter);

                txt.text = "Reloj";
                break;
            case 4:
                anim.SetInteger("animationTransition", counter);
                anim.SetInteger("animationReverse", counter);

                txt.text = "Hospital";
                break;
            case 5:
                anim.SetInteger("animationTransition", counter);
                anim.SetInteger("animationReverse", counter);

                txt.text = "Quimica";
                break;
            case 6:
                anim.SetInteger("animationTransition", counter);
                anim.SetInteger("animationReverse", counter);

                txt.text = "Transferencia";
                break;
        }
    }

    private void Previous() {
        counter--;
        if (counter < 1)
        {
            counter = 5;
        }
        switch (counter)
        { case 1:
                
                anim.SetInteger("animationReverse", counter);
                anim.SetInteger("animationTransition", counter);
                

                txt.text = "Transferencia";
                break;
            case 2:
                anim.SetInteger("animationReverse", counter);
                anim.SetInteger("animationTransition", counter);

                txt.text = "Grado";
                break;
            case 3:
                anim.SetInteger("animationReverse", counter);
                anim.SetInteger("animationTransition", counter);

                txt.text = "Reloj";
                break;
            case 4:
                anim.SetInteger("animationReverse", counter);
                anim.SetInteger("animationTransition", counter);

                txt.text = "Hospital";
                break;
            case 5:
                anim.SetInteger("animationReverse", counter);
                anim.SetInteger("animationTransition", counter);

                txt.text = "Quimica";
                break;
            case 6:
                anim.SetInteger("animationReverse", counter);
                anim.SetInteger("animationTransition", counter);

                txt.text = "Quimica";
                break;
        }
    }
}
