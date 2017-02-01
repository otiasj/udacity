using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ScreenControl : MonoBehaviour {

    public float fadeTime = 1f;
    Color solidColor;
    Color fadedColor;
    bool fading;
    bool faded;
    Renderer myRenderer;
    public AudioSource audioSource;
    public GameObject[] objectsToTrigger;

    // Use this for initialization
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        solidColor = myRenderer.material.color;
        fadedColor = new Color(solidColor.r, solidColor.g, solidColor.b, 0f);
        for (int i = 0; i < objectsToTrigger.Length; i++)
        {
            objectsToTrigger[i].SetActive(false);
        }
    }
	
    public void Play()
    {
        fading = true;
        Debug.Log("PLAY!");
        for (int i = 0; i < objectsToTrigger.Length; i++)
        {
            objectsToTrigger[i].SetActive(true);
        }
        audioSource.Play();
    }

    public void Pause()
    {
        Debug.Log("PAUSE...");
        fading = false;
        for (int i = 0; i < objectsToTrigger.Length; i++)
        {
            objectsToTrigger[i].SetActive(false);
        }
        audioSource.Stop();
    }
}
