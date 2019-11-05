using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEstrtuctura : MonoBehaviour
{

   public GameObject mostrar;

   private void Start()
   {
      mostrar.SetActive(false);
   }

   void OnMouseDown()
   {
      mostrar.SetActive(true);
   }
}
