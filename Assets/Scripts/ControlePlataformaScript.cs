using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlePlataformaScript : MonoBehaviour {


    public float limiteEsquerdo, limiteDireito;
    public float velocidade;
    public Button btnr;
    public Button btnl;

    // Use this for initialization
    void Start () {
  
     //       Screen.orientation = ScreenOrientation.LandscapeLeft;
     
    }
	
	// Update is called once per frame
	void Update () {
        Mover();
       
    }


    public void MoverEsquerda()
    {

        float move_x = 13  * velocidade * Time.deltaTime;


        transform.Translate(move_x, 0, 0.0f);

        if (transform.position.x < limiteEsquerdo || transform.position.x > limiteDireito)
        {

            transform.position = new Vector2(transform.position.x * -1, transform.position.y);

        }
    }

    public void MoverDireita()
    {
        float move_x = -13 * velocidade * Time.deltaTime;

         
            transform.Translate(move_x, 0, 0.0f);

        if (transform.position.x < limiteEsquerdo || transform.position.x > limiteDireito)
        {

            transform.position = new Vector2(transform.position.x * -1, transform.position.y);

        }


    }



    void Mover()
    {
        float move_x = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;

        transform.Translate(move_x, 0, 0.0f);
       

    }

}
