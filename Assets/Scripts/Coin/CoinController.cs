using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
     //   ScoreManager.countPrueba += 5; //Variable de Prueba, incrementa +5 y se presenta en pantalla.
        ScoreManager.scoreManager.Puntuacion(1); //asigna la puntuacion
        Destroy(transform.parent.gameObject); //Destruye el Padre del Objeto que contiene el Script Actual
    }
}
