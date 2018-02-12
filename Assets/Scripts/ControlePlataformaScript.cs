using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlePlataformaScript : MonoBehaviour {


    public float limiteEsquerdo, limiteDireito;
    public float velocidade;
    public Button btnr;
    public Button btnl;
 

    private Touch touch;

    private Rigidbody2D myBody;
    void Start () {
    
       
    }
 
	void Update () {
        Mover(); 
    }

    //TODO: REMOVER
    public void MoverEsquerda()
    {

        float move_x = 13  * velocidade * Time.deltaTime;
  

        if (transform.position.x < limiteEsquerdo || transform.position.x > limiteDireito)
        {

            transform.position = new Vector2(transform.position.x * -1, transform.position.y);

        }
    }

    //TODO: REMOVER
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

       
        if(Input.touchCount > 0)
        {
            //  Vector3 stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0));

            touch = Input.GetTouch(0);
            float middle = Screen.width / 2;

            print(Input.touchCount);

            
           

            if (touch.position.x < middle )
            {
  
                if (transform.position.x >= limiteEsquerdo)
                {
                  
                    transform.Translate(-2 * velocidade * Time.deltaTime, 0, 0.0f);
                    
                }
                    

            }


            if (touch.position.x > middle)
            { 

                if (transform.position.x < limiteDireito)  
                { 
                    transform.Translate( 2 * velocidade * Time.deltaTime, 0, 0.0f);

                }

              
            };
        }
   }


}
