using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontuacaoScript : MonoBehaviour {

    public Text txtPontos; 

    public static int score;
 

    void Update()
    {
        txtPontos.text = PontuacaoScript.score.ToString();
        
    }
}
