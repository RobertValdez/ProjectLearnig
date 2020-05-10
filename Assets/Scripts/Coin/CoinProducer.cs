using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinProducer : MonoBehaviour
{
    public GameObject coinPrefab;

    private void Start()
    {if (SceneManager.GetActiveScene().name == "SampleScene")
    {
        for (int i = 0; i < 50; i++)
        {
            float x = Random.Range(-15f, 1);
            float y = Random.Range(0, 50);

            Vector3 position = new Vector3(x, y, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(coinPrefab, position, rotation);
            }
        }
    }
    void Update()
    {
       // ScoreManager.timer += Time.deltaTime; //Tiempo por Segundos, Incrementable
        int Segundos = (int)ScoreManager.timer;
        ScoreManager.countTime = Segundos;
        if (SceneManager.GetActiveScene().name == "SampleScene"
          && Segundos == 50)
        {
            ScoreManager.timer = 0;
            SceneManager.LoadScene("SampleScene");
        }
        /*if (timer >= 2f)
        {
            timer = 0;
            float x = Random.Range(-15f, 1);
            float y = Random.Range(0, 50);

            Vector3 position = new Vector3(x,y,0);
            Quaternion rotation = new Quaternion();
            Instantiate(coinPrefab, position,rotation);   
        } */
    }
}
