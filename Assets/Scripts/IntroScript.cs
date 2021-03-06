﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class IntroScript : MonoBehaviour {

    public Text intro;
    public Text intro2;
    public Button btn;

    public AudioClip voice;
    public AudioSource audioSource;
    public AudioSource musicGame;


 
    //btn
    public void  LoadIntro()
    {
        //Debug.Log("You have clicked the button!");

        PlayAudio();
        //SceneManager.LoadScene("game");
    }

    void PlayAudio()
    {
        btn.interactable = false;
      
        float clipLength = voice.length;

        musicGame.Stop();
        audioSource.PlayOneShot(voice, 0.7F);
        StartCoroutine(StartMethod(clipLength));
       
    }

    private IEnumerator StartMethod(float clipLength)
    {
        yield return new WaitForSeconds(clipLength);

        SceneManager.LoadScene("game");

    }

    void Start()
    {
        musicGame.Stop();
        StartCoroutine(FadeTextToFullAlpha(2f, intro, null));
        StartCoroutine(FadeTextToFullAlpha(2f, intro2, musicGame));
       
         


    }
    void Update()
    {
        
           

    }

    public IEnumerator MoveButtom(float t, Button b)
    {


        float move_y = 1 * 4 * Time.deltaTime;
        b.transform.position = new Vector3(0,  1f * (Time.deltaTime / 1f) , transform.position.z);
        
 

        StopCoroutine("MoveButtom");
        yield return null;
      
    }

    public IEnumerator FadeTextToFullAlpha(float t, Text i, AudioSource a)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        musicGame.Play();
        btn.gameObject.SetActive(true);
        StartCoroutine(FadeTextToFullAlphaButtom(2f, btn));
    }

    public IEnumerator FadeTextToFullAlphaButtom(float t, Button i )
    {
        i.image.color = new Color(i.image.color.r, i.image.color.g, i.image.color.b, 0);
        while (i.image.color.a < 1.0f)
        {
            i.image.color = new Color(i.image.color.r, i.image.color.g, i.image.color.b, i.image.color.a + (Time.deltaTime / t));
            yield return null;
        }
     
    }



    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
