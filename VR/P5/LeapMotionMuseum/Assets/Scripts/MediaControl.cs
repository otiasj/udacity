using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaControl : MonoBehaviour, Callback {

    public int firstScreenIndex = 1;
    public GameObject[] screens;
    private ScreenControl screenControl;

    private bool isPlaying = false;
    private int currentIndex = 0;

    public void clickPlayPause()
    {
        if (screenControl != null)
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
            screenControl = screens[currentIndex].GetComponent<ScreenControl>();
            screenControl.Play();
        } else {
            screenControl = null;
        }
    }

    public void onStartMoving(int destinationIndex)
    {
        if (screenControl != null)
        {
            screenControl.Pause();
            isPlaying = false;
        }
    }
}
