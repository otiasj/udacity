using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ScreenControl : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip audioclip;
    public GameObject[] objectsToTrigger;

    private MovieTexture texture;

    // Use this for initialization
    void Start()
    {
        if (objectsToTrigger != null)
        {
            for (int i = 0; i < objectsToTrigger.Length; i++)
            {
                objectsToTrigger[i].SetActive(false);
            }
        }

        if (GetComponent<Renderer>() != null)
        {
            texture = (MovieTexture)GetComponent<Renderer>().material.mainTexture;
        }
    }

    public void Play()
    {
        Debug.Log("PLAY!");
        for (int i = 0; i < objectsToTrigger.Length; i++)
        {
            objectsToTrigger[i].SetActive(true);
        }
        if (audioclip != null)
        {
            audioSource.clip = audioclip;
        }
        audioSource.Play();
        if (texture != null)
        {
            texture.Play();
        }
    }

    public void Pause()
    {
        Debug.Log("PAUSE...");
        for (int i = 0; i < objectsToTrigger.Length; i++)
        {
            objectsToTrigger[i].SetActive(false);
        }
        audioSource.Stop();
        if (texture != null)
        {
            texture.Stop();
        }
    }
}
