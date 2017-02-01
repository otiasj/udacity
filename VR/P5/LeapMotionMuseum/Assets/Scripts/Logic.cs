using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour {

    public GameObject player;
    public GameObject[] waypoints;
    public GameObject[] callbacks;
    public AudioSource overSound;
    private int currentDisplayIndex = 0;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    /**
     * Move to the next waypoint
     */
    public void moveToNextWaypoint()
    {
        currentDisplayIndex++;
        if (currentDisplayIndex >= waypoints.Length)
        {
            currentDisplayIndex = 0;
        }
        overSound.Play();
        moveToWaypointWithIndex(currentDisplayIndex);
    }

    /**
     * Move to the previous waypoint if there is one available
     */
    public void moveToPrevWaypoint()
    {
        currentDisplayIndex--;
        if (currentDisplayIndex < 0)
        {
            currentDisplayIndex = 0;
        }
        else
        {
            moveToWaypointWithIndex(currentDisplayIndex);
            overSound.Play();
        }
    }

    /*
     * This is called after the player has reached the new position
     */
    public void onPositionReached()
    {
        Debug.Log("Reached target");
        for (int i = 0; i < callbacks.Length; i++)
        {
            Callback callback = (Callback) callbacks[i].GetComponent<Callback>();
            callback.onDestinationReached(currentDisplayIndex);
        }
        overSound.Stop(); 
    }

    private void moveToWaypointWithIndex(int index)
    {
        GameObject targetPosition = waypoints[index];
        Debug.Log("Moving to : " + index,  targetPosition);

        for (int i = 0; i < callbacks.Length; i++)
        {
            Callback callback = (Callback)callbacks[i].GetComponent<Callback>();
            callback.onStartMoving(index);
        }

        iTween.MoveTo(player,
           iTween.Hash(
               "position", targetPosition.transform.position,
               "time", 4,
               "easetype", "linear",
               "oncomplete", "onPositionReached",
               "oncompletetarget", this.gameObject
           )
       );
    }


}
