using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaScript : MonoBehaviour {
 
    public int vel;
    public int velMax;

    private Rigidbody2D myBody;

    // Use this for initialization
    void Start () {
        velMax = 5;
        myBody = this.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D target)
    {

        if (target.gameObject.tag == "bloco")
        {
            Destroy(target.gameObject);
        }

       if (target.gameObject.tag == "plataforma")  
        {

            // myBody.AddForce(new Vector2(vel * Random.Range(-10, 10), 300));
            myBody.AddForce(new Vector2(vel * Random.Range(-10, 10), 300));

            if (vel < velMax)
            {

                vel = vel + 1;

            }

        }
    }

}
