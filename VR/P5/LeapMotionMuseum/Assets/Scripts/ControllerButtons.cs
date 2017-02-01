using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerButtons : MonoBehaviour {
    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip; //Essentially this is accessing
                                                                                   //SteamVR_TrackedObject.cs and telling our script
                                                                                   //and defining it here.


    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    private Valve.VR.EVRButtonId Axis0 = Valve.VR.EVRButtonId.k_EButton_Axis0;
    private Valve.VR.EVRButtonId Axis1 = Valve.VR.EVRButtonId.k_EButton_Axis1;
    private Valve.VR.EVRButtonId Axis2 = Valve.VR.EVRButtonId.k_EButton_Axis2;
    private Valve.VR.EVRButtonId Axis3 = Valve.VR.EVRButtonId.k_EButton_Axis3;
    private Valve.VR.EVRButtonId Axis4 = Valve.VR.EVRButtonId.k_EButton_Axis4;

    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;

    private GameObject pickup;

    public CartControls trigger;

    // Use this for initialization
    void Start()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller == null)
        {
            Debug.Log("Controller not initialized");
        }
        if (controller.GetAxis() != Vector2.zero)
        {
            Debug.Log(gameObject.name + controller.GetAxis());
        }

        if (controller.GetHairTriggerDown())
        {
            Debug.Log(gameObject.name + " Trigger Press");
            trigger.Enter();
        }

        if (controller.GetHairTriggerUp())
        {
            Debug.Log(gameObject.name + " Trigger Release");
            trigger.Click();
        }

        if (controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip Press");
        }

        if (controller.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip Release");
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("OnTriggerEnter");
        pickup = collider.gameObject;
        
    }
    private void OnTriggerExit(Collider collider)
    {
        Debug.Log("OnTriggerExit");
        pickup = collider.gameObject;
        
    }
}
