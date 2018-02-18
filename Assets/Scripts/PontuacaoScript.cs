using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PontuacaoScript : MonoBehaviour {

    public Text txtPontos;
  

    public static int score;
 

    void Update()
    {   
        txtPontos.text = PontuacaoScript.score.ToString();
        
        if(score == 11)
        {
            SceneManager.LoadScene("intro");
        }
    }
}
