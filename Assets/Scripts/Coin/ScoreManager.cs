using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManager;

    public static int countTime;

    public Text scoreText;
    public Text WinText;
    int score = 0;
    public static float timer;
    public static bool Finish = false;

    public GameObject OpenScene2;

    private void Start()
    {
        //Aquí compruebo que al cambiar de escena no se destruyan los generados por ScoreManager
        if (scoreManager == null)
        {
            scoreManager = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject); //Destruir gameObject actual y sus Scripts
        }
        
        /* Debug.Log("Reinicio");
        rb = GameObject.FindGameObjectWithTag("Finish");
        rb.SetActive(false); */

        /*    if (SceneManager.GetActiveScene().name == "SampleScene"
          && OpenScene2 == null)
       {
           // Debug.Log("eNTRO");
           OpenScene2 = GameObject.FindGameObjectWithTag("Finish1");
           // Debug.Log(OpenScene2.name);
       } */
    }

    private void Update()
    {
        
     /* GameObject gb = new GameObject();
        gb = GameObject.FindGameObjectWithTag("Finish");
        gb.SetActive(false); */
        //Cuando se carga la nueva escena si el Texto de Puntuacion es null,
        //se busca y se asigna nuevamente con el nuevo componente creado
        if (SceneManager.GetActiveScene().name == "SampleScene"
          && Finish == false)
        {
            timer += Time.deltaTime;
        }

        if (SceneManager.GetActiveScene().name == "SampleScene"
          && scoreText == null)
        {
            score = 0;
            scoreText = GameObject.Find("Text").GetComponent<Text>();
            scoreText.text = "Monedas: " + score;
        }
         if (SceneManager.GetActiveScene().name == "SampleScene"
          && WinText == null)
        {
            WinText = GameObject.Find("Text Win").GetComponent<Text>();
        } 
    }
    public void Puntuacion(int point)
    {
        //Aquí se obtienen por parámetro los puntos, y se presentan
        score += point;
        scoreText.text = "Monedas: " + score;

        if (SceneManager.GetActiveScene().name == "SampleScene"
          && score == 50)
        {
            Finish = true;
            GoUpArrow.ImageShow = true;
            WinText.text = "Ganaste!!";
            Vector3 position = new Vector3(8.486f, 45.989f, -5.9375f);
            Quaternion quaternion = new Quaternion();
            Instantiate(OpenScene2, position, quaternion);
        }

        //Si coutPrueba es igual a 20, se cambiará a la Escena2
        /*  if (countPrueba == 20)
         {
             SceneManager.LoadScene("Scene2");
         } */
    }
}
