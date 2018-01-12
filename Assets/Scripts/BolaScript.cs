using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaScript : MonoBehaviour {
 
    public int ballforce;

 

    private Rigidbody2D myBody;

    // Use this for initialization
    void Start () {
       
        myBody = this.GetComponent<Rigidbody2D>(); 
        myBody.AddForce(new Vector2(ballforce, ballforce));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D target)
    {

        if (target.gameObject.tag == "bloco")
        {
            PontuacaoScript.score++; 
            Destroy(target.gameObject);
        }

       if (target.gameObject.tag == "plataforma")  
        {

            // myBody.AddForce(new Vector2(vel * Random.Range(-10, 10), 300)); 

        }
    }

}
