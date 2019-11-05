using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEstrtuctura : MonoBehaviour
{

   public GameObject mostrar;
   private bool status;
   private void Start()
   {
      status = false;
      mostrar.SetActive(status);
   }

   void OnMouseDown()
   {
      status = !status;
      mostrar.SetActive(status);
   }
}
