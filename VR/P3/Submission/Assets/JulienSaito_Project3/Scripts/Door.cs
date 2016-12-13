using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    private bool locked = true;
    private bool openingDoor = false;
    private Vector3 initialPosition;
    public AudioClip openDoorSound;
    public AudioClip closedDoorSound;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update() {
        if (!locked) {
            if (openingDoor) {
                // Animate the door raising up
                if (transform.position.y < 4.0f)
                {
                    transform.Translate(0, 2.5f * Time.deltaTime, 0, Space.World);
                }
            }
            else
            {
                // Animate the door closing
                if (transform.position.y > initialPosition.y)
                {
                    transform.Translate(0, -2.5f * Time.deltaTime, 0, Space.World);
                }
            }
        }        
    }

    public void openOrClose()
    {
        if (openingDoor)
        {
            openingDoor = false;
        }
        else
        {
            if (locked)
            {
                playSound(closedDoorSound);
            }
            else
            {
                playSound(openDoorSound);
                openingDoor = true;
            }
        }
        
    }

    private void playSound(AudioClip clipToPlay)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = clipToPlay;
        audio.Play();
    }

    public void Unlock()
    {
        locked = false;
    }
}
