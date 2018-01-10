using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiBolaScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter2D(Collision2D target)
    {

        if (target.gameObject.tag == "bola")
        {
            Destroy(target.gameObject);
            GameOverScript.isGameOver = true;
        } 
        
    }

}
