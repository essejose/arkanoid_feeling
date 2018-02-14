using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaScript : MonoBehaviour {
 
    public int ballforce;
     
    private Rigidbody2D myBody;

    bool shotball = false;
    public GameObject player;
    public GameObject painel;
    private Vector3 offset;



    void Start () {
       
        myBody = this.GetComponent<Rigidbody2D>();
        offset = transform.position - player.transform.position;
        painel.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {



        if (!GameSceneController.inGame)
        {
            transform.position = player.transform.position + offset;
        }

    }

    public void shotBall()
    {
        //if (!shotball && Input.GetButtonDown("Fire1") && !GameSceneController.inGame)
        // {

            ControlePlataformaScript.movePlatform = false;
            GameSceneController.inGame = true;
            shotball = true;
            myBody.AddForce(new Vector2(ballforce, ballforce));
            painel.SetActive(false); 
            ControlePlataformaScript.movePlatform = true;

        //}



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
            myBody.velocity = new Vector2((float)(myBody.velocity.x + .1), (float)(myBody.velocity.y + .1));
            //   myBody.AddForce(new Vector2(1 * Random.Range(-10, 10), 300)); 

        }
    }

}
