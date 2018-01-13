using System.Collections;
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
        StartCoroutine(FadeTextToFullAlpha(2f, intro));
        StartCoroutine(FadeTextToFullAlpha(2f, intro2));
     //   StartCoroutine(MoveButtom(1f, btn));
       

    }
    void Update()
    {
        
           

    }

    public IEnumerator MoveButtom(float t, Button b)
    {


        float move_y = 175 * 2 * Time.deltaTime;

        b.transform.Translate(0, move_y, 0);
        StopCoroutine("MoveButtom");
        yield return null;
      
    }

    public IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
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
