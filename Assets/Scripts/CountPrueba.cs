using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountPrueba : MonoBehaviour
{
    //3 Pasos básicos para los Scripts de UI
    Text _Text;
    private void Awake() {
        _Text = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update(){
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "SampleScene")
        {
            _Text.text = "Tiempo: " + ScoreManager.countTime;
        }
    }
}
