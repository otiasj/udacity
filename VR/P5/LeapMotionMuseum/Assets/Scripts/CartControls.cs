using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartControls : MonoBehaviour, Callback
{
    public bool isLeftButton = true;
    private enum State
    {
        Idle,
        Focused,
        Clicked
    }

    [SerializeField]
    private State _state = State.Idle;
    public Color _color_original = new Color(0.0f, 1.0f, 0.0f, 0.5f);
    private AudioSource _audio_source = null;
    public Color color_hilight = new Color(0.8f, 0.8f, 1.0f, 0.125f);

    [Header("Sounds")]
    public AudioClip clip_click = null;

    public Logic gameLogic;

    // Use this for initialization
    void Start()
    {
        _audio_source = gameObject.GetComponent<AudioSource>();
        _audio_source.clip = clip_click;
        _audio_source.playOnAwake = false;
        gameObject.GetComponent<Renderer>().material.color = _color_original;
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision with " + other.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        switch (_state)
        {
            case State.Idle:
                Idle();
                break;

            case State.Focused:
                Focus();
                break;

            case State.Clicked:
                Clicked();
                break;
            default:
                break;
        }
    }

    private void Idle()
    {
        //float scale = Mathf.Lerp(scale_idle_min, scale_idle_max, _animated_lerp);
        //_scale = Mathf.Lerp(_scale, scale, lerp_idle);
        gameObject.GetComponent<Renderer>().material.color = _color_original;
    }

    public void Focus()
    {
        gameObject.GetComponent<Renderer>().material.color = color_hilight;
    }


    public void Clicked()
    {
        gameObject.GetComponent<Renderer>().material.color = color_hilight;
    }

    public void Enter()
    {
        _state = _state == State.Idle ? State.Focused : _state;
    }


    public void Exit()
    {
        _state = State.Idle;
    }


    public void Click()
    {
        _state = _state == State.Focused ? State.Clicked : _state;

        _audio_source.Play();

        if (isLeftButton)
        {
            gameLogic.moveToNextWaypoint();
        }
        else
        {
            gameLogic.moveToPrevWaypoint();
        }
    }

    public void onDestinationReached(int destinationIndex)
    {
        _state = State.Idle;
    }

    public void onStartMoving(int destinationIndex)
    {
    }
}
