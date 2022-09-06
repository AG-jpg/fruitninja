using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   public int puntaje;
   public Text textoPuntaje;

   public void AumentarPuntaje()
   {
    puntaje += 2;
    textoPuntaje.text = puntaje.ToString();
   }
}
