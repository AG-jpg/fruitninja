using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   [Header("Elementos del Puntaje")]
   public int puntaje;
   public int mejorPuntaje;
   public Text textoPuntaje;
   public Text textoMejorPuntaje;

   [Header("Elementos Game Over")]
   public GameObject panelGameOver;
   public Text puntajeFinal;
   public Text textoMejorPuntajePanel;
   

   public void Awake() {
      panelGameOver.SetActive(false);
      PonerMejorPuntaje();
   }

   private void PonerMejorPuntaje()
   {
      mejorPuntaje = PlayerPrefs.GetInt("MejorPuntaje");
      textoMejorPuntaje.text = "Best Score: " + mejorPuntaje;
   }

   public void AumentarPuntaje()
   {
    puntaje += 2;
    textoPuntaje.text = puntaje.ToString();

    if(puntaje > mejorPuntaje)
    {
      PlayerPrefs.SetInt("MejorPuntaje", puntaje);
      textoMejorPuntaje.text = "Best: " + puntaje.ToString();
      mejorPuntaje = puntaje;
    }
   }

   public void TocarBomba()
   {
      panelGameOver.SetActive(true);
      puntajeFinal.text = "Score: " + puntaje.ToString();
      textoMejorPuntajePanel.text = "Best Score " + mejorPuntaje.ToString();
      Time.timeScale = 0;
   }

   public void Reiniciar()
   {
      puntaje = 0;
      textoPuntaje.text = puntaje.ToString();
      Time.timeScale = 1;
      panelGameOver.SetActive(false);

      foreach(GameObject g in GameObject.FindGameObjectsWithTag("Interactivo"))
      {
         Destroy(g);
      }
   }
}
