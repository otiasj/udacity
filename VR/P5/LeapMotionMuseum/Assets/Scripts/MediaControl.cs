using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaControl : MonoBehaviour, Callback {

    public int firstScreenIndex = 3;
    public GameObject[] screens;
    private MovieTexture texture;
    private ScreenControl screenControl;
    private int currentIndex = 0;

    private bool isPlaying = false;

    // Use this for initialization
    void Start () {
        if (screens[currentIndex].GetComponent<Renderer>() != null)
        {
            texture = (MovieTexture)screens[currentIndex].GetComponent<Renderer>().material.mainTexture;
        }
    }
	
    public void clickPlayPause()
    {
        if (texture != null)
        {
            if (isPlaying)
            {
                texture.Pause();
                isPlaying = false;
            }
            else
            {
                texture.Play();
                isPlaying = true;
            }
        } else if (screenControl != null)
        {
            if (isPlaying)
            {
                screenControl.Pause();
                isPlaying = false;
            }
            else
            {
                screenControl.Play();
                isPlaying = true;
            }
        }
    }

    public void onDestinationReached(int destinationIndex)
    {
        currentIndex = destinationIndex - firstScreenIndex;
        Debug.Log("Reached screen "+currentIndex);
        if (currentIndex >= 0 && currentIndex < screens.Length)
        {
            if (screens[currentIndex].GetComponent<Renderer>() != null)
            {
                texture = (MovieTexture)screens[currentIndex].GetComponent<Renderer>().material.mainTexture;
                texture.Play();
            } else
            {
                screenControl = screens[currentIndex].GetComponent<ScreenControl>();
                screenControl.Play();
            }
        } else {
            texture = null;
        }
    }

    public void onStartMoving(int destinationIndex)
    {
        if (texture != null)
        {
            texture.Pause();
            isPlaying = false;
        }
        else if (screenControl != null)
        {
            screenControl.Pause();
            isPlaying = false;
        }
    }
}
