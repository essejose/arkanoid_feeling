using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePlataformaScript : MonoBehaviour {


    public float limiteEsquerdo, limiteDireito;
    public float velocidade;
  

    // Use this for initialization
    void Start () {
  
            Screen.orientation = ScreenOrientation.LandscapeLeft;
     
    }
	
	// Update is called once per frame
	void Update () {
        Mover();
       
    }

    void Mover()
    {
        float move_x = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;

        transform.Translate(move_x, 0, 0.0f);
       

    }

}
