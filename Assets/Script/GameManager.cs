using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   [Header("Elementos del Puntaje")]
   public int puntaje;
   public Text textoPuntaje;
   public Text puntajeFinal;

   [Header("Elementos Game Over")]
   public GameObject panelGameOver;

   public void Awake() {
      panelGameOver.SetActive(false);
   }

   public void AumentarPuntaje()
   {
    puntaje += 2;
    textoPuntaje.text = puntaje.ToString();
   }

   public void TocarBomba()
   {
      panelGameOver.SetActive(true);
      textoPuntaje.text = "Score: " + puntaje.ToString();
      Time.timeScale = 0;
   }

   public void Reiniciar()
   {
      puntaje = 0;
      textoPuntaje.text = "0";
      Time.timeScale = 1;
      panelGameOver.SetActive(false);
      puntajeFinal.text = "0";

      foreach(GameObject g in GameObject.FindGameObjectsWithTag("Interactivo"))
      {
         Destroy(g);
      }
   }
}
