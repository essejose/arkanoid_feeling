using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour {

    public GameObject Painel;



    public static bool isGameOver = false;



    // Update is called once per frame
    void Update () {

        if (isGameOver)
        {

            Painel.SetActive(true);
            
        }
    }

   public void restartGame()
    {
        PontuacaoScript.score = 0;
        isGameOver = false;
        GameSceneController.inGame = false;
        Painel.SetActive(false);

        SceneManager.LoadScene("game");
    }
}
