using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
